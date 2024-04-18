namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapfileheader
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPFILEHEADER
{
    public ushort bfType;
    public uint bfSize;
    public ushort bfReserved1;
    public ushort bfReserved2;
    public uint bfOffBits;
}
