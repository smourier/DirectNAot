namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineeme
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("50dc93e4-ba4f-4275-ae66-83e836e57469")]
public partial interface IMFMediaEngineEME
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineeme-get_keys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Keys(out IMFMediaKeys keys);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineeme-setmediakeys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaKeys(IMFMediaKeys keys);
}
