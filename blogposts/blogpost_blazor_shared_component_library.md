# Creating and Using a Blazor Shared Component Library

In this blog post, we will walk through the process of creating a Blazor Shared Component Library Project, including shared JavaScript files using the `HeadContent` tag, and writing components with parameters. This guide will help you understand how to extend your Blazor solution with reusable components and shared resources.

## Step-by-Step Guide on Creating a Blazor Shared Component Library Project

1. **Create a New Blazor Shared Component Library Project**
   - Open your solution in Visual Studio.
   - Right-click on the solution and select `Add > New Project`.
   - Choose `Blazor Component Library` and name it `BlazorWasm.Shared`.
   - Set the `TargetFramework` to `net9.0` in the `BlazorWasm.Shared.csproj` file.

2. **Add the New Project to the Solution**
   - Open the `BlazorWasm.sln` file.
   - Add the following entry to include the new project:
     ```xml
     Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "BlazorWasm.Shared", "BlazorWasm.Shared\BlazorWasm.Shared.csproj", "{A1B2C3D4-E5F6-7890-1234-56789ABCDEF0}"
     EndProject
     ```

## Including Shared JavaScript Files Using the `HeadContent` Tag

To include shared JavaScript files in your Blazor components, you can use the `HeadContent` tag. This allows you to add scripts that will be included in the HTML head section when the component is rendered.

### Example

1. **Create a Shared Component**
   - Add a new Razor component file named `SharedComponent.razor` in the `Components` folder of the `BlazorWasm.Shared` project.
   - Include the `HeadContent` tag to reference a shared JavaScript file:
     ```razor
     @page "/shared-component"

     @using Microsoft.AspNetCore.Components

     <HeadContent>
         <script src="shared.js"></script>
     </HeadContent>

     <h3>@Title</h3>

     @code {
         [Parameter]
         public string Title { get; set; }
     }
     ```

2. **Create the Code-Behind File**
   - Add a code-behind file named `SharedComponent.razor.cs` to define the `Title` parameter:
     ```csharp
     using Microsoft.AspNetCore.Components;

     namespace BlazorWasm.Shared.Components
     {
         public partial class SharedComponent : ComponentBase
         {
             [Parameter]
             public string Title { get; set; }
         }
     }
     ```

## Writing Components with Parameters in the Shared Library

Blazor components can accept parameters, allowing you to pass data to them when they are used. This makes the components more flexible and reusable.

### Example

1. **Define a Parameter in the Component**
   - In the `SharedComponent.razor` file, we have already defined a `Title` parameter using the `[Parameter]` attribute.

2. **Use the Component in Another Project**
   - In your main Blazor project, you can now use the `SharedComponent` and pass a value to the `Title` parameter:
     ```razor
     @page "/example"

     <h3>Example Page</h3>

     <BlazorWasm.Shared.Components.SharedComponent Title="Hello from Shared Component!" />
     ```

By following these steps, you can create a Blazor Shared Component Library, include shared JavaScript files, and write components with parameters. This approach helps you build reusable and maintainable components that can be shared across different projects in your Blazor solution.
