#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_actual_output_format
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OPM_ACTUAL_OUTPUT_FORMAT
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint ulStatusFlags;
    public uint ulDisplayWidth;
    public uint ulDisplayHeight;
    public DXVA2_SampleFormat dsfSampleInterleaveFormat;
    public D3DFORMAT d3dFormat;
    public uint ulFrequencyNumerator;
    public uint ulFrequencyDenominator;
}
