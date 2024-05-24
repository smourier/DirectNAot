#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_output_id_data
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OPM_OUTPUT_ID_DATA
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint ulStatusFlags;
    public ulong OutputId;
}
