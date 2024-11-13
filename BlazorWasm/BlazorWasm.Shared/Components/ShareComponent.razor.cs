using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.Shared.Components;

public partial class ShareComponent : ComponentBase, IAsyncDisposable
{
    private Lazy<Task<IJSObjectReference>> _moduleTask = null!;

    [Inject]
    public IJSRuntime JSRuntime { get; set; } = null!;
    
    [Parameter] public string Text { get; set; } = null!;
    [Parameter] public string Url { get; set; } = null!;
    [Parameter] public string Title { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        
        _moduleTask = new Lazy<Task<IJSObjectReference>>(() => JSRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/BlazorWasm.Shared/Components/ShareComponent.razor.js").AsTask());
    }

    private async Task ShareContent()
    {
        IJSObjectReference module = await _moduleTask.Value;
        await module.InvokeVoidAsync("Share.share", Text, Url, Title);
    }

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            IJSObjectReference module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}