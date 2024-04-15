namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgifactory3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("25483823-cd46-4c7d-86ca-47aa95b837bd")]
public partial interface IDXGIFactory3 : IDXGIFactory2
{
    [PreserveSig]
    uint GetCreationFlags();
}
