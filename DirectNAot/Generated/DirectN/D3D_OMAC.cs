#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3d-omac
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D_OMAC
{
    public InlineArrayByte_16 Omac;
}
