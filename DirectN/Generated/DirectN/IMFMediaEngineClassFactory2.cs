#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineclassfactory2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("09083cef-867f-4bf6-8776-dee3a7b42fca")]
public partial interface IMFMediaEngineClassFactory2
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactory2-createmediakeys2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeys2(BSTR keySystem, BSTR defaultCdmStorePath, BSTR inprivateCdmStorePath, out IMFMediaKeys ppKeys);
}
