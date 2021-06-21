namespace My.Custom.Lib

[<AutoOpen>]
module Lib =
    
    //open FSharp.Data
    open SwaggerProvider

    type BigOpenApi = OpenApiClientProvider<"https://petstore.swagger.io/v2/swagger.json">

    type BigOpenApi2 = OpenApiClientProvider<"https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/uspto.json">

    type BigOpenApi3 = OpenApiClientProvider<"https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/petstore-expanded.yaml">

    type BigOpenapi4 = OpenApiClientProvider<"https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v2.0/json/uber.json">

    type Callback = OpenApiClientProvider<"https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/callback-example.json">