namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicrect
[StructLayout(LayoutKind.Sequential)]
public partial struct WICRect
{
    public int X;
    public int Y;
    public int Width;
    public int Height;
}
