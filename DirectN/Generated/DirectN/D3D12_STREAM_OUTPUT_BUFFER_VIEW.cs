#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_stream_output_buffer_view
public partial struct D3D12_STREAM_OUTPUT_BUFFER_VIEW
{
    public ulong BufferLocation;
    public ulong SizeInBytes;
    public ulong BufferFilledSizeLocation;
}
