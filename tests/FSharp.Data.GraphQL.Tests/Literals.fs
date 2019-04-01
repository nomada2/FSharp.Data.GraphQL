module FSharp.Data.GraphQL.Tests.Literals

let [<Literal>] IntrospectionSchemaJson = """{
    "documentId": 869718943,
    "data": {
      "__schema": {
        "queryType": {
          "name": "Query"
        },
        "mutationType": {
          "name": "Mutation"
        },
        "subscriptionType": {
          "name": "Subscription"
        },
        "types": [
          {
            "kind": "SCALAR",
            "name": "Int",
            "description": "The `Int` scalar type represents non-fractional signed whole numeric values. Int can represent values between -(2^31) and 2^31 - 1.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "String",
            "description": "The `String` scalar type represents textual data, represented as UTF-8 character sequences. The String type is most often used by GraphQL to represent free-form human-readable text.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "Boolean",
            "description": "The `Boolean` scalar type represents `true` or `false`.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "Float",
            "description": "The `Float` scalar type represents signed double-precision fractional values as specified by [IEEE 754](http://en.wikipedia.org/wiki/IEEE_floating_point).",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "ID",
            "description": "The `ID` scalar type represents a unique identifier, often used to refetch an object or as key for a cache. The ID type appears in a JSON response as a String; however, it is not intended to be human-readable. When expected as an input type, any string (such as `\"4\"`) or integer (such as `4`) input value will be accepted as an ID.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "Date",
            "description": "The `Date` scalar type represents a Date value with Time component. The Date type appears in a JSON response as a String representation compatible with ISO-8601 format.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "SCALAR",
            "name": "URI",
            "description": "The `URI` scalar type represents a string resource identifier compatible with URI standard. The URI type appears in a JSON response as a String.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__Schema",
            "description": "A GraphQL Schema defines the capabilities of a GraphQL server. It exposes all available types and directives on the server, as well as the entry points for query, mutation, and subscription operations.",
            "fields": [
              {
                "name": "directives",
                "description": "A list of all directives supported by this server.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "OBJECT",
                        "name": "__Directive"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "mutationType",
                "description": "If this server supports mutation, the type that mutation operations will be rooted at.",
                "args": [],
                "type": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "queryType",
                "description": "The type that query operations will be rooted at.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Type",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "subscriptionType",
                "description": "If this server support subscription, the type that subscription operations will be rooted at.",
                "args": [],
                "type": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "types",
                "description": "A list of all types supported by this server.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "OBJECT",
                        "name": "__Type"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__Directive",
            "description": "A Directive provides a way to describe alternate runtime execution and type validation behavior in a GraphQL document. In some cases, you need to provide options to alter GraphQL’s execution behavior in ways field arguments will not suffice, such as conditionally including or skipping a field. Directives provide this by describing additional information to the executor.",
            "fields": [
              {
                "name": "args",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "OBJECT",
                        "name": "__InputValue"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "description",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "locations",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "__DirectiveLocation"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "onField",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "onFragment",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "onOperation",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__InputValue",
            "description": "Arguments provided to Fields or Directives and the input fields of an InputObject are represented as Input Values which describe their type and optionally a default value.",
            "fields": [
              {
                "name": "defaultValue",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "description",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "type",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Type",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__Type",
            "description": "The fundamental unit of any GraphQL Schema is the type. There are many kinds of types in GraphQL as represented by the `__TypeKind` enum. Depending on the kind of a type, certain fields describe information about that type. Scalar types provide no information beyond a name and description, while Enum types provide their values. Object and Interface types provide the fields they describe. Abstract types, Union and Interface, provide the Object types possible at runtime. List and NonNull types compose other types.",
            "fields": [
              {
                "name": "description",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "enumValues",
                "description": null,
                "args": [
                  {
                    "name": "includeDeprecated",
                    "description": null,
                    "type": {
                      "kind": "SCALAR",
                      "name": "Boolean",
                      "ofType": null
                    },
                    "defaultValue": "False"
                  }
                ],
                "type": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__EnumValue",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "fields",
                "description": null,
                "args": [
                  {
                    "name": "includeDeprecated",
                    "description": null,
                    "type": {
                      "kind": "SCALAR",
                      "name": "Boolean",
                      "ofType": null
                    },
                    "defaultValue": "False"
                  }
                ],
                "type": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__Field",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "inputFields",
                "description": null,
                "args": [],
                "type": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__InputValue",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "interfaces",
                "description": null,
                "args": [],
                "type": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__Type",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "kind",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "ENUM",
                    "name": "__TypeKind",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "ofType",
                "description": null,
                "args": [],
                "type": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "possibleTypes",
                "description": null,
                "args": [],
                "type": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__Type",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__EnumValue",
            "description": "One possible value for a given Enum. Enum values are unique values, not a placeholder for a string or numeric value. However an Enum value is returned in a JSON response as a string.",
            "fields": [
              {
                "name": "deprecationReason",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "description",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "isDeprecated",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "__Field",
            "description": "Object and Interface types are described by a list of Fields, each of which has a name, potentially a list of arguments, and a return type.",
            "fields": [
              {
                "name": "args",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "OBJECT",
                        "name": "__InputValue"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "deprecationReason",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "description",
                "description": null,
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "isDeprecated",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "type",
                "description": null,
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Type",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "ENUM",
            "name": "__TypeKind",
            "description": "An enum describing what kind of type a given __Type is.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": [
              {
                "name": "SCALAR",
                "description": "Indicates this type is a scalar.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "OBJECT",
                "description": "Indicates this type is an object. `fields` and `interfaces` are valid fields.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "INTERFACE",
                "description": "Indicates this type is an interface. `fields` and `possibleTypes` are valid fields.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "UNION",
                "description": "Indicates this type is a union. `possibleTypes` is a valid field.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "ENUM",
                "description": "Indicates this type is an enum. `enumValues` is a valid field.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "INPUT_OBJECT",
                "description": "Indicates this type is an input object. `inputFields` is a valid field.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "LIST",
                "description": "Indicates this type is a list. `ofType` is a valid field.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "NON_NULL",
                "description": "Indicates this type is a non-null. `ofType` is a valid field.",
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "possibleTypes": null
          },
          {
            "kind": "ENUM",
            "name": "__DirectiveLocation",
            "description": "A Directive can be adjacent to many parts of the GraphQL language, a __DirectiveLocation describes one such possible adjacencies.",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": [
              {
                "name": "QUERY",
                "description": "Location adjacent to a query operation.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "MUTATION",
                "description": "Location adjacent to a mutation operation.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "SUBSCRIPTION",
                "description": "Location adjacent to a subscription operation.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "FIELD",
                "description": "Location adjacent to a field.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "FRAGMENT_DEFINITION",
                "description": "Location adjacent to a fragment definition.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "FRAGMENT_SPREAD",
                "description": "Location adjacent to a fragment spread.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "INLINE_FRAGMENT",
                "description": "Location adjacent to an inline fragment.",
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Query",
            "description": null,
            "fields": [
              {
                "name": "droid",
                "description": "Gets droid",
                "args": [
                  {
                    "name": "id",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "String",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  }
                ],
                "type": {
                  "kind": "OBJECT",
                  "name": "Droid",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "hero",
                "description": "Gets human hero",
                "args": [
                  {
                    "name": "id",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "String",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  }
                ],
                "type": {
                  "kind": "OBJECT",
                  "name": "Human",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "planet",
                "description": "Gets planet",
                "args": [
                  {
                    "name": "id",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "String",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  }
                ],
                "type": {
                  "kind": "OBJECT",
                  "name": "Planet",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "things",
                "description": "Gets things",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INTERFACE",
                        "name": "Thing"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Droid",
            "description": "A mechanical creature in the Star Wars universe.",
            "fields": [
              {
                "name": "appearsIn",
                "description": "Which movies they appear in.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "Episode"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "friends",
                "description": "The friends of the Droid, or an empty list if they have none.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "UNION",
                      "name": "Character",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "id",
                "description": "The id of the droid.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": "The name of the Droid.",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "primaryFunction",
                "description": "The primary function of the droid.",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "ENUM",
            "name": "Episode",
            "description": "One of the films in the Star Wars Trilogy",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": [
              {
                "name": "NewHope",
                "description": "Released in 1977.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "Empire",
                "description": "Released in 1980.",
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "Jedi",
                "description": "Released in 1983.",
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "possibleTypes": null
          },
          {
            "kind": "UNION",
            "name": "Character",
            "description": "A character in the Star Wars Trilogy",
            "fields": null,
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": [
              {
                "kind": "OBJECT",
                "name": "Human",
                "ofType": null
              },
              {
                "kind": "OBJECT",
                "name": "Droid",
                "ofType": null
              }
            ]
          },
          {
            "kind": "OBJECT",
            "name": "Human",
            "description": "A humanoid creature in the Star Wars universe.",
            "fields": [
              {
                "name": "appearsIn",
                "description": "Which movies they appear in.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "Episode"
                      }
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "friends",
                "description": "The friends of the human, or an empty list if they have none.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "UNION",
                      "name": "Character",
                      "ofType": null
                    }
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "homePlanet",
                "description": "The home planet of the human, or null if unknown.",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "id",
                "description": "The id of the human.",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": "The name of the human.",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Planet",
            "description": "A planet in the Star Wars universe.",
            "fields": [
              {
                "name": "id",
                "description": "The id of the planet",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "isMoon",
                "description": "Is that a moon?",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "Boolean",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "name",
                "description": "The name of the planet.",
                "args": [],
                "type": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "INTERFACE",
            "name": "Thing",
            "description": "Gets the shape of the thing.",
            "fields": [
              {
                "name": "format",
                "description": "The format of the shape",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "id",
                "description": "The ID of the shape",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": null,
            "enumValues": null,
            "possibleTypes": [
              {
                "kind": "OBJECT",
                "name": "Box",
                "ofType": null
              },
              {
                "kind": "OBJECT",
                "name": "Ball",
                "ofType": null
              }
            ]
          },
          {
            "kind": "OBJECT",
            "name": "Subscription",
            "description": null,
            "fields": [
              {
                "name": "watchMoon",
                "description": "Watches to see if a planet is a moon",
                "args": [
                  {
                    "name": "id",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "String",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  }
                ],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "Planet",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Mutation",
            "description": null,
            "fields": [
              {
                "name": "setMoon",
                "description": "Sets a moon status",
                "args": [
                  {
                    "name": "id",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "String",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  },
                  {
                    "name": "isMoon",
                    "description": null,
                    "type": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "SCALAR",
                        "name": "Boolean",
                        "ofType": null
                      }
                    },
                    "defaultValue": null
                  }
                ],
                "type": {
                  "kind": "OBJECT",
                  "name": "Planet",
                  "ofType": null
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Ball",
            "description": "A ball.",
            "fields": [
              {
                "name": "format",
                "description": "The format of the ball",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "id",
                "description": "The ID of the ball",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [
              {
                "kind": "INTERFACE",
                "name": "Thing",
                "ofType": null
              }
            ],
            "enumValues": null,
            "possibleTypes": null
          },
          {
            "kind": "OBJECT",
            "name": "Box",
            "description": "A box.",
            "fields": [
              {
                "name": "format",
                "description": "The format of the box",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              },
              {
                "name": "id",
                "description": "The ID of the box",
                "args": [],
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                },
                "isDeprecated": false,
                "deprecationReason": null
              }
            ],
            "inputFields": null,
            "interfaces": [
              {
                "kind": "INTERFACE",
                "name": "Thing",
                "ofType": null
              }
            ],
            "enumValues": null,
            "possibleTypes": null
          }
        ],
        "directives": [
          {
            "name": "include",
            "description": "Directs the executor to include this field or fragment only when the `if` argument is true.",
            "locations": [
              "FIELD",
              "FRAGMENT_SPREAD",
              "INLINE_FRAGMENT"
            ],
            "args": [
              {
                "name": "if",
                "description": "Included when true.",
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "defaultValue": null
              }
            ]
          },
          {
            "name": "skip",
            "description": "Directs the executor to skip this field or fragment when the `if` argument is true.",
            "locations": [
              "FIELD",
              "FRAGMENT_SPREAD",
              "INLINE_FRAGMENT"
            ],
            "args": [
              {
                "name": "if",
                "description": "Skipped when true.",
                "type": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  }
                },
                "defaultValue": null
              }
            ]
          },
          {
            "name": "defer",
            "description": "Defers the resolution of this field or fragment",
            "locations": [
              "FIELD",
              "FRAGMENT_DEFINITION",
              "FRAGMENT_SPREAD",
              "INLINE_FRAGMENT"
            ],
            "args": []
          },
          {
            "name": "stream",
            "description": "Streams the resolution of this field or fragment",
            "locations": [
              "FIELD",
              "FRAGMENT_DEFINITION",
              "FRAGMENT_SPREAD",
              "INLINE_FRAGMENT"
            ],
            "args": []
          },
          {
            "name": "live",
            "description": "Subscribes for live updates of this field or fragment",
            "locations": [
              "FIELD",
              "FRAGMENT_DEFINITION",
              "FRAGMENT_SPREAD",
              "INLINE_FRAGMENT"
            ],
            "args": []
          }
        ]
      }
    }
  }"""