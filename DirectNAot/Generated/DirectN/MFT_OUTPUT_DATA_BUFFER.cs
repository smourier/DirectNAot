#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ns-mftransform-mft_output_data_buffer
[StructLayout(LayoutKind.Sequential)]
public partial struct MFT_OUTPUT_DATA_BUFFER
{
    public uint dwStreamID;
    public nint pSample;
    public uint dwStatus;
    public nint pEvents;
}
