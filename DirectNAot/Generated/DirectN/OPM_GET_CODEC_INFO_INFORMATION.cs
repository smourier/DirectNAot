namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_get_codec_info_information
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_GET_CODEC_INFO_INFORMATION
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint Merit;
}
