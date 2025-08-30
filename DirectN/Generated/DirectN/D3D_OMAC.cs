#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3d-omac
public partial struct D3D_OMAC : IValueGet<byte[]>
{
    public InlineArrayByte_16 Omac;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Omac).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Omac).ToArray();
}
