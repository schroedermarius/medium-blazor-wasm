# Blazor WebAssembly Hosted Project (with ASP.NET Core Controllers and Query Parameters)
This project demonstrates a hosted Blazor WebAssembly application built with .NET 9, providing a structure for developing frontend applications with backend API support in a single project setup.
It's designed as a reference [for this blog post](https://medium.com/@mariusschroeder/getting-started-with-blazor-webassembly-hosted-on-net-9-an-adventure-in-modern-web-hosting-74ab5563064d) and covers how to handle data requests, pass query parameters, and configure a multi-project Blazor solution in .NET 9 (also applicable for .NET 8).

## Project Overview
This solution consists of three main projects:

1. __BlazorWasm.Server__: Acts as the ASP.NET Core server, serving both API endpoints and the client project. It hosts static files, handles API requests, and can support additional server-side features.
2. __BlazorWasm.Client__: The Blazor WebAssembly project containing the client-side UI, handling navigation, and making HTTP requests to the server-side APIs.
3. __BlazorWasm.Shared__: A shared component library project that contains reusable components, services, and models that can be used across both the client and server projects.

By keeping all projects in sync, this hosted setup simplifies deployment while enabling a clean separation of client, server, and shared concerns.

## Features
- ASP.NET Core API for backend functionality.
- HTTP requests from client to server using HttpClient.
- Query parameter support for flexible data requests.
- Interactive WebAssembly rendering mode, adjusted for seamless HTTP requests.
- Shared component library for reusable components and services.
- Azure compatibility with easy deployment as a single web app, ideal for hosting behind an Azure Front Door.

## Project Structure
- Client Project (BlazorWasm.Client):
  - Contains main client components, pages, and layouts.
  - Implements HTTP client configuration and lifecycle-aware requests.
- Server Project (BlazorWasm.Server):
  - Hosts static files for client use and contains backend API controllers.
  - Serves as a single entry point for the hosted setup, streaming WebAssembly assets to the client.
- Shared Project (BlazorWasm.Shared):
  - Contains reusable components, services, and models.
  - Provides a centralized location for shared logic and UI elements.

## Setup
To run this project locally:

Build and run the project:

`dotnet run --project BlazorWasm.Server`

Open a browser and navigate to `https://localhost:5001` (or the configured port) to view the app.

## Prerequisites
- .NET 9 SDK or .NET 8 SDK
- Visual Studio or JetBrains Rider

## Usage
This project includes a `Status` page that makes an HTTP GET request to an API endpoint on the server.

### Example Usage of Query Parameter
The Status page accepts an `Id` parameter. To use this:

1. Navigate to `/status` to see the default status.
2. Use `/status/{Id}` to pass an integer `Id` and receive custom output.

### Customizing the API
1. Add new pages to the client project and controllers to the server project.
2. Register dependencies in Program.cs for both client and server as needed.

### Using the Shared Component Library
1. Add new components to the shared project.
2. Reference shared components in the client project by using the `@using` directive.

## Contributing
Contributions are welcome! If you find issues or have improvements, please submit a pull request or open an issue.

## License
This project is licensed under the MIT License.