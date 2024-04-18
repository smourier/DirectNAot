namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapinfoheader
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPINFOHEADER
{
    public uint biSize;
    public int biWidth;
    public int biHeight;
    public ushort biPlanes;
    public ushort biBitCount;
    public uint biCompression;
    public uint biSizeImage;
    public int biXPelsPerMeter;
    public int biYPelsPerMeter;
    public uint biClrUsed;
    public uint biClrImportant;
}
