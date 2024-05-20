#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_configure_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_CONFIGURE_PARAMETERS
{
    public OPM_OMAC omac;
    public Guid guidSetting;
    public uint ulSequenceNumber;
    public uint cbParametersSize;
    public InlineArrayByte_4056 abParameters;
}
