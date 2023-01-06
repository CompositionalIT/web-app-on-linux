# F# Web App on Azure App Service Linux

1. Open `deploy.fsx` in a text editor of your choice.
1. Replace `ENTER-WEB-APP-NAME-HERE` with a globally unique web app name (URL will be `<yourname>.azurewebsites.net`)
1. Optionally replace `fsharpwebapponlinux` with a resource group of your choice.
1. Change the SKU from `WebApp.Sku.P3V3` to a web app [SKU of your choice](https://azure.microsoft.com/en-gb/pricing/details/app-service/windows/).
1. `dotnet publish -c Release` to build the application locally.
1. `dotnet fsi deploy.fsx` to deploy it to Azure.

### Make sure you remember to delete the resource when done!