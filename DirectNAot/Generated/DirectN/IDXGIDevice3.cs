namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgidevice3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("6007896c-3244-4afd-bf18-a6d3beda5023")]
public partial interface IDXGIDevice3 : IDXGIDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidevice3-trim
    [PreserveSig]
    public void Trim();
}
