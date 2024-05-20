#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ns-mftransform-mft_input_stream_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MFT_INPUT_STREAM_INFO
{
    public long hnsMaxLatency;
    public uint dwFlags;
    public uint cbSize;
    public uint cbMaxLookahead;
    public uint cbAlignment;
}
