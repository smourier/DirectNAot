namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_standard_information
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_STANDARD_INFORMATION
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint ulStatusFlags;
    public uint ulInformation;
    public uint ulReserved;
    public uint ulReserved2;
}
