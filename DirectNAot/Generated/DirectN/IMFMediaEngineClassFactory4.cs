namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineclassfactory4
[GeneratedComInterface, Guid("fbe256c1-43cf-4a9b-8cb8-ce8632a34186")]
public partial interface IMFMediaEngineClassFactory4
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactory4-createcontentdecryptionmodulefactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateContentDecryptionModuleFactory(PWSTR keySystem, in Guid riid, out nint ppvObject);
}
