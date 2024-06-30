#nullable enable
namespace DirectN;

public partial struct DDVIDEOPORTSTATUS
{
    public uint dwSize;
    public BOOL bInUse;
    public uint dwFlags;
    public uint dwReserved1;
    public DDVIDEOPORTCONNECT VideoPortType;
    public nuint dwReserved2;
    public nuint dwReserved3;
}
