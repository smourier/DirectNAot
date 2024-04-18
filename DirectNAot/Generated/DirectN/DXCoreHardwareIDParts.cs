namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXCoreHardwareIDParts
{
    public uint vendorID;
    public uint deviceID;
    public uint subSystemID;
    public uint subVendorID;
    public uint revisionID;
}
