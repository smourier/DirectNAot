#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_get_info_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_GET_INFO_PARAMETERS
{
    public OPM_OMAC omac;
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public Guid guidInformation;
    public uint ulSequenceNumber;
    public uint cbParametersSize;
    public InlineArrayByte_4056 abParameters;
}
