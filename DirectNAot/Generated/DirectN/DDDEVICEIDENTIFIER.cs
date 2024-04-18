namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDDEVICEIDENTIFIER
{
    public InlineArrayCHAR512 szDriver;
    public InlineArrayCHAR512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
    public Guid guidDeviceIdentifier;
}
