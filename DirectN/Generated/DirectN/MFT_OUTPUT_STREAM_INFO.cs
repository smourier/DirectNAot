#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ns-mftransform-mft_output_stream_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MFT_OUTPUT_STREAM_INFO
{
    public uint dwFlags;
    public uint cbSize;
    public uint cbAlignment;
}
