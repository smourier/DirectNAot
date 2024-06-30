#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvp/ns-dvp-ddvideoportinfo
public partial struct DDVIDEOPORTINFO
{
    public uint dwSize;
    public uint dwOriginX;
    public uint dwOriginY;
    public uint dwVPFlags;
    public RECT rCrop;
    public uint dwPrescaleWidth;
    public uint dwPrescaleHeight;
    public nint lpddpfInputFormat;
    public nint lpddpfVBIInputFormat;
    public nint lpddpfVBIOutputFormat;
    public uint dwVBIHeight;
    public nuint dwReserved1;
    public nuint dwReserved2;
}
