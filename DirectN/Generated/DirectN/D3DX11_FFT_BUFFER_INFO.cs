#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/ns-d3dcsx-d3dx11_fft_buffer_info
public partial struct D3DX11_FFT_BUFFER_INFO
{
    public uint NumTempBufferSizes;
    public InlineArrayUInt32_4 TempBufferFloatSizes;
    public uint NumPrecomputeBufferSizes;
    public InlineArrayUInt32_4 PrecomputeBufferFloatSizes;
}
