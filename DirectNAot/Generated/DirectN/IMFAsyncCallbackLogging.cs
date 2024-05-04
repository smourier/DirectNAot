#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfasynccallbacklogging
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c7a4dca1-f5f0-47b6-b92b-bf0106d25791")]
public partial interface IMFAsyncCallbackLogging : IMFAsyncCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasynccallbacklogging-getobjectpointer
    [PreserveSig]
    void GetObjectPointer();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasynccallbacklogging-getobjecttag
    [PreserveSig]
    uint GetObjectTag();
}
