#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_present_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_PRESENT_PARAMETERS
{
    public uint DirtyRectsCount;
    public nint pDirtyRects;
    public nint pScrollRect;
    public nint pScrollOffset;
}
