#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_hdcp_key_selection_vector
public partial struct OPM_HDCP_KEY_SELECTION_VECTOR : IValueGet<byte[]>
{
    public InlineArrayByte_5 abKeySelectionVector;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)abKeySelectionVector).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)abKeySelectionVector).ToArray();
}
