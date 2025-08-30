#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtforientation
public partial struct HrtfOrientation : IValueGet<float[]>
{
    public InlineArraySingle_9 element;
    
    readonly float[]? IValueGet<float[]>.GetValue() => ((ReadOnlySpan<float>)element).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<float>)element).ToArray();
}
