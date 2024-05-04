#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_requested_information
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_REQUESTED_INFORMATION
{
    public OPM_OMAC omac;
    public uint cbRequestedInformationSize;
    public InlineArrayByte4076 abRequestedInformation;
}
