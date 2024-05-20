#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDDEVICEIDENTIFIER
{
    public InlineArrayFoundationCHAR_512 szDriver;
    public InlineArrayFoundationCHAR_512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
    public Guid guidDeviceIdentifier;
}
