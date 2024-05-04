#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineneedkeynotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("46a30204-a696-4b18-8804-246b8f031bb1")]
public partial interface IMFMediaEngineNeedKeyNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineneedkeynotify-needkey
    [PreserveSig]
    void NeedKey(nint /* optional byte* */ initData, uint cb);
}
