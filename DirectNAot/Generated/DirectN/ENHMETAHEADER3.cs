#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ENHMETAHEADER3
{
    public uint iType;
    public uint nSize;
    public RECTL rclBounds;
    public RECTL rclFrame;
    public uint dSignature;
    public uint nVersion;
    public uint nBytes;
    public uint nRecords;
    public ushort nHandles;
    public ushort sReserved;
    public uint nDescription;
    public uint offDescription;
    public uint nPalEntries;
    public SIZE szlDevice;
    public SIZE szlMillimeters;
}
