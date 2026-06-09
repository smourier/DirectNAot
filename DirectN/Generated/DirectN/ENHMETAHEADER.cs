#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enhmetaheader
public partial struct ENHMETAHEADER
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
    public uint cbPixelFormat;
    public uint offPixelFormat;
    public uint bOpenGL;
    public SIZE szlMicrometers;
}
