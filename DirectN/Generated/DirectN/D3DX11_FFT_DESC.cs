#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/ns-d3dcsx-d3dx11_fft_desc
public partial struct D3DX11_FFT_DESC
{
    public uint NumDimensions;
    public InlineArrayUInt32_32 ElementLengths;
    public uint DimensionMask;
    public D3DX11_FFT_DATA_TYPE Type;
}
