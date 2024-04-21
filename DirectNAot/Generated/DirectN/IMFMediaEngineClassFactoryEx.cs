namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineclassfactoryex
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e")]
public partial interface IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-createmediasourceextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaSourceExtension(uint dwFlags, IMFAttributes pAttr, out IMFMediaSourceExtension ppMSE);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-createmediakeys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeys(BSTR keySystem, BSTR? cdmStorePath, out IMFMediaKeys ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-istypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTypeSupported(BSTR? type, BSTR keySystem, [MarshalAs(UnmanagedType.U4)] out bool isSupported);
}
