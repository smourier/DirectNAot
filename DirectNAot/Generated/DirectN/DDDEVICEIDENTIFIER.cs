#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDDEVICEIDENTIFIER
{
    public InlineArrayFoundationCHAR512 szDriver;
    public InlineArrayFoundationCHAR512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
    public Guid guidDeviceIdentifier;
}
