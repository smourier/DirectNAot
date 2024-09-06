#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaenginesrcelementsex
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("654a6bb3-e1a3-424a-9908-53a43a0dfda0")]
public partial interface IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElements
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelementsex-addelementex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddElementEx(BSTR pURL, BSTR pType, BSTR pMedia, BSTR keySystem);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelementsex-getkeysystem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeySystem(uint index, out BSTR pType);
}
