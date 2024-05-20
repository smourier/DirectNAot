#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_swap_chain_fullscreen_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_SWAP_CHAIN_FULLSCREEN_DESC
{
    public DXGI_RATIONAL RefreshRate;
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    public DXGI_MODE_SCALING Scaling;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Windowed;
}
