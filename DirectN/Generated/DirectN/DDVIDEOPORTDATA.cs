#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddvideoportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTDATA
{
    public uint dwVideoPortId;
    public uint dwVPFlags;
    public uint dwOriginOffset;
    public uint dwHeight;
    public uint dwVBIHeight;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
}
