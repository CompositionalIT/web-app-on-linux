open Saturn
open Giraffe

let app = application {
    use_router (text "Hello from Saturn, Giraffe and ASP .NET!")
}

run app