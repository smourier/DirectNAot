namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ns-dxcore_interface-dxcorehardwareid
[StructLayout(LayoutKind.Sequential)]
public partial struct DXCoreHardwareID
{
    public uint vendorID;
    public uint deviceID;
    public uint subSysID;
    public uint revision;
}
