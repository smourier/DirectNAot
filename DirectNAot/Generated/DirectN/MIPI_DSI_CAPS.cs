namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MIPI_DSI_CAPS
{
    public byte DSITypeMajor;
    public byte DSITypeMinor;
    public byte SpecVersionMajor;
    public byte SpecVersionMinor;
    public byte SpecVersionPatch;
    public ushort TargetMaximumReturnPacketSize;
    public byte ResultCodeFlags;
    public byte ResultCodeStatus;
    public byte Revision;
    public byte Level;
    public byte DeviceClassHi;
    public byte DeviceClassLo;
    public byte ManufacturerHi;
    public byte ManufacturerLo;
    public byte ProductHi;
    public byte ProductLo;
    public byte LengthHi;
    public byte LengthLo;
}
