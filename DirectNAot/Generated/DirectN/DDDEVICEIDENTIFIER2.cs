namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-dddeviceidentifier2
[StructLayout(LayoutKind.Sequential)]
public partial struct DDDEVICEIDENTIFIER2
{
    public InlineArrayCHAR512 szDriver;
    public InlineArrayCHAR512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
    public Guid guidDeviceIdentifier;
    public uint dwWHQLLevel;
}
