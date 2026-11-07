#nullable enable
namespace DirectN;

public partial struct DXGI_SWAP_CHAIN_DESC2
{
    public uint Width;
    public uint Height;
    public DXGI_FORMAT Format;
    public BOOL Stereo;
    public DXGI_SAMPLE_DESC SampleDesc;
    public DXGI_USAGE BufferUsage;
    public uint BufferCount;
    public DXGI_SCALING Scaling;
    public DXGI_SWAP_EFFECT SwapEffect;
    public DXGI_ALPHA_MODE AlphaMode;
    public uint Flags;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
