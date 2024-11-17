using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Shared.Components;

public partial class LottiePlayerComponent
{
    [Parameter]
    public string Class { get; set; } = null!;

    [Parameter]
    public bool AutoPlay { get; set; } = true;

    [Parameter]
    public bool Loop { get; set; } = true;

    [Parameter]
    public string Mode { get; set; } = "normal";

    [Parameter]
    public string Source { get; set; } = null!;

    private IDictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>();

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (AutoPlay)
        {
            AdditionalAttributes.Add("autoplay", true);
        }

        if (Loop)
        {
            AdditionalAttributes.Add("loop", true);
        }
    }
}
