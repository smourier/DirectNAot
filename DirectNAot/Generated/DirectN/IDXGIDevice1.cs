namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgidevice1
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("77db970f-6276-48ba-ba28-070143b4392c")]
public partial interface IDXGIDevice1 : IDXGIDevice
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice1-setmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaximumFrameLatency(uint MaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice1-getmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumFrameLatency(out uint pMaxLatency);
}
