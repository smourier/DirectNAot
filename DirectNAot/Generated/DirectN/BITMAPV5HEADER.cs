namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapv5header
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPV5HEADER
{
    public uint bV5Size;
    public int bV5Width;
    public int bV5Height;
    public ushort bV5Planes;
    public ushort bV5BitCount;
    public BI_COMPRESSION bV5Compression;
    public uint bV5SizeImage;
    public int bV5XPelsPerMeter;
    public int bV5YPelsPerMeter;
    public uint bV5ClrUsed;
    public uint bV5ClrImportant;
    public uint bV5RedMask;
    public uint bV5GreenMask;
    public uint bV5BlueMask;
    public uint bV5AlphaMask;
    public uint bV5CSType;
    public CIEXYZTRIPLE bV5Endpoints;
    public uint bV5GammaRed;
    public uint bV5GammaGreen;
    public uint bV5GammaBlue;
    public uint bV5Intent;
    public uint bV5ProfileData;
    public uint bV5ProfileSize;
    public uint bV5Reserved;
}
