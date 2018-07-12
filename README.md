# Minimal ASP.NET Core Web App (Razor Pages) template

This template consists of a single content page (`Index`) with layout and error pages. For information
about the remaining pages and code files, see the article 
[Get started with Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-2.1#project-files-and-folders).

## Background

I needed to create a basic Web application - a single page with a few controls and an API call. 
I enjoyed working with Azure Functions, the related [Core Tools](https://github.com/Azure/azure-functions-core-tools)
package and VS Code, seemlessly switching between Windows and Ubuntu machines.

Since my first [serverless endavour](https://github.com/chopeen/last-fm-not-mine-alert-func) was so successful and
I read about Razor Pages a few times recently, I decided to use .NET Core for the Web application, too.

## New project

I installed .NET Core SDK (v2.1.301), executed `dotnet new razor` and saw a new project that was way more complex
than I expected. You can check the [inital import](/tree/a2e71aec1537bc803707a1eded2013a1c6d8eed4) to see what 
I mean - I was needed a simple scaffolding and got a full-blown application.

I spent some time looking for a minimal template of ASP.NET Core Web App project, found none and this is why this
repository was created.

## The road to the minimal template

I looked for unimportant elements, removed them and then removed unreferenced pieces left behind:

- libraries:
  - Bootstrap
  - jQuery 
- pages:
  - `_ValidationScriptsPartial` (a reference to the jQuery validation scripts removed earlier)
  - `Contact`
  - `About`
  - `Privacy` (along with some cookie consent code)
- images
- most of CSS styling

I kept the directory structure inside `wwwroot`.

## Links

 - [Publishing a Web Core app to Azure with CLI](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-cli?view=aspnetcore-2.1&tabs=other)

    git push azure master

## TODO
  1. Rename the repository
  1. Add tags, description, etc
  1. ~~Explain why a stripped-down template was created and how it was done~~
   - ~~commands~~
   - ~~dotnet version~~
   - ~~contents (1 page + layout + error page + ...)~~
   - screenshot
  1. Once ready, replace _Lorem Ipsum_ with the above description
  1. Add information about publishing to Azure
