#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_swap_chain_desc
public partial struct DXGI_SWAP_CHAIN_DESC
{
    public DXGI_MODE_DESC BufferDesc;
    public DXGI_SAMPLE_DESC SampleDesc;
    public DXGI_USAGE BufferUsage;
    public uint BufferCount;
    public HWND OutputWindow;
    public BOOL Windowed;
    public DXGI_SWAP_EFFECT SwapEffect;
    public uint Flags;
}
