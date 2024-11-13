using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Shared.Components
{
    public partial class SharedComponent : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }
    }
}
