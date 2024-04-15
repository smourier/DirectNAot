namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_present_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_PRESENT_PARAMETERS
{
    public uint DirtyRectsCount;
    public RECT pDirtyRects;
    public RECT pScrollRect;
    public POINT pScrollOffset;
}
