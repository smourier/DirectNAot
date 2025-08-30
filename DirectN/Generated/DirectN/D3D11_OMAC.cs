#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_omac
public partial struct D3D11_OMAC : IValueGet<byte[]>
{
    public InlineArrayByte_16 Omac;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Omac).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Omac).ToArray();
}
