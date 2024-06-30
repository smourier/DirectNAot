#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ns-mediaobj-dmo_output_data_buffer
public partial struct DMO_OUTPUT_DATA_BUFFER
{
    public nint pBuffer;
    public uint dwStatus;
    public long rtTimestamp;
    public long rtTimelength;
}
