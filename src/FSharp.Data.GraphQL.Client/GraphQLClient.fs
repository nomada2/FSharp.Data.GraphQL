/// The MIT License (MIT)
/// Copyright (c) 2016 Bazinga Technologies Inc

namespace FSharp.Data.GraphQL

open System
open System.Net
open FSharp.Data.GraphQL
open FSharp.Data.GraphQL.Client

type GraphQLClientConnection() =
    let client = new WebClient()
    member internal __.Client = client
    interface IDisposable with
        member x.Dispose() = client.Dispose()

type GraphQLRequest  =
    { ServerUrl : string
      HttpHeaders: seq<string * string>
      OperationName : string option
      Query : string
      Variables : (string * obj) [] }

module GraphQLClient =
    let private rethrow (exns : exn list) =
        let rec mapper (acc : string) (exns : exn list) =
            let aggregateMapper (ex : AggregateException) = mapper "" (List.ofSeq ex.InnerExceptions)
            match exns with
            | [] -> acc
            | ex :: tail ->
                match ex with
                | :? AggregateException as ex -> aggregateMapper ex
                | ex -> mapper (acc + " " + ex.Message) tail
        failwithf "Failure calling GraphQL server. %s" (mapper "" exns)

    let private configureWebClient (httpHeaders : seq<string * string>) (client : WebClient)=
        client.Headers.Set("content-type", "application/json")
        if not (isNull httpHeaders)
        then httpHeaders |> Seq.iter (fun (n, v) -> client.Headers.Set(n, v))

    let sendRequestAsync (connection : GraphQLClientConnection) (request : GraphQLRequest) =
        async {
            let client = connection.Client
            configureWebClient request.HttpHeaders client
            let variables = 
                match request.Variables with
                | null | [||] -> JsonValue.Null
                | _ -> 
                    let json = Map.ofSeq request.Variables |> Serialization.toJsonValue
                    json.ToString() |> JsonValue.String
            let operationName =
                match request.OperationName with
                | Some x -> JsonValue.String x
                | None -> JsonValue.Null
            let requestJson =         
                [| "operationName", operationName
                   "query", JsonValue.String request.Query
                   "variables", variables |]
                |> JsonValue.Record
            return! client.UploadStringTaskAsync(request.ServerUrl, requestJson.ToString()) |> Async.AwaitTask
        }
       
    let sendIntrospectionRequestAsync (connection : GraphQLClientConnection) (serverUrl : string) httpHeaders =
        let sendGet () =
            async {
                let client = connection.Client
                configureWebClient httpHeaders client
                return!
                    client.DownloadStringTaskAsync(serverUrl)
                    |> Async.AwaitTask
            }
        async {
            try return! sendGet ()
            with getex ->
                let request =
                    { ServerUrl = serverUrl
                      HttpHeaders = httpHeaders
                      OperationName = None
                      Query = Introspection.IntrospectionQuery
                      Variables = [||] }
                try return! sendRequestAsync connection request
                with postex -> return rethrow [getex; postex]
        }

    let sendIntrospectionRequest client serverUrl httpHeaders = 
        sendIntrospectionRequestAsync client serverUrl httpHeaders
        |> Async.RunSynchronously

    let sendRequest client request =
        sendRequestAsync client request
        |> Async.RunSynchronously