# Blazor Desktop Test App

This project demonstrate a solution template for a desktop blazor app.

It is based on [blazor-desktop-crossplatform-sample from @edandersen](https://github.com/edandersen/blazor-desktop-crossplatform-sample).

It consists of 3 projects:

- BlazorDesktopApp.App, which contains all blazor components and is shared between all platforms
- BlazorDesktopApp.Forms, which is a Windows Forms app, using WebView2 to render the Blazor Server App.
- BlazorDesktopApp.Web, which is a traditional Web app, hosting the Blazor Server App, mostly used during development