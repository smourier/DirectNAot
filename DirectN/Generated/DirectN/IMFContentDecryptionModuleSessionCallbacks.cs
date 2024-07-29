#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nn-mfcontentdecryptionmodule-imfcontentdecryptionmodulesessioncallbacks
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("3f96ee40-ad81-4096-8470-59a4b770f89a")]
public partial interface IMFContentDecryptionModuleSessionCallbacks
{
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodulesessioncallbacks-keymessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyMessage(MF_MEDIAKEYSESSION_MESSAGETYPE messageType, nint /* byte array */ message, uint messageSize, PWSTR destinationURL);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodulesessioncallbacks-keystatuschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyStatusChanged();
}
