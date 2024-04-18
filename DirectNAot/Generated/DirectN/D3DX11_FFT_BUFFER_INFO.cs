namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/ns-d3dcsx-d3dx11_fft_buffer_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DX11_FFT_BUFFER_INFO
{
    public uint NumTempBufferSizes;
    public InlineArrayUInt324 TempBufferFloatSizes;
    public uint NumPrecomputeBufferSizes;
    public InlineArrayUInt324 PrecomputeBufferFloatSizes;
}
