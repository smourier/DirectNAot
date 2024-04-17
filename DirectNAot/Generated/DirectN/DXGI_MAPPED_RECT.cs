namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_mapped_rect
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_MAPPED_RECT
{
    public int Pitch;
    public nint pBits;
}
