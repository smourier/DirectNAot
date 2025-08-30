#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_val16
public partial struct DRM_VAL16 : IValueGet<byte[]>
{
    public InlineArrayByte_16 val;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)val).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)val).ToArray();
}
