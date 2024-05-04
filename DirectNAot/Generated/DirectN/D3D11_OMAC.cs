#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_omac
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_OMAC
{
    public InlineArrayByte16 Omac;
}
