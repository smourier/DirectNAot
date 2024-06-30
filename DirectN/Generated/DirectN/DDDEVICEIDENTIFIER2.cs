#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-dddeviceidentifier2
public partial struct DDDEVICEIDENTIFIER2
{
    public InlineArrayFoundationCHAR_512 szDriver;
    public InlineArrayFoundationCHAR_512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
    public Guid guidDeviceIdentifier;
    public uint dwWHQLLevel;
}
