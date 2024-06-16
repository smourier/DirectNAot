#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dpresent-parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DPRESENT_PARAMETERS
{
    public uint BackBufferWidth;
    public uint BackBufferHeight;
    public D3DFORMAT BackBufferFormat;
    public uint BackBufferCount;
    public D3DMULTISAMPLE_TYPE MultiSampleType;
    public uint MultiSampleQuality;
    public D3DSWAPEFFECT SwapEffect;
    public HWND hDeviceWindow;
    public BOOL Windowed;
    public BOOL EnableAutoDepthStencil;
    public D3DFORMAT AutoDepthStencilFormat;
    public uint Flags;
    public uint FullScreen_RefreshRateInHz;
    public uint PresentationInterval;
}
