#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_swap_chain_desc1
public partial struct DXGI_SWAP_CHAIN_DESC1
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
}
