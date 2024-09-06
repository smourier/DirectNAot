#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetcredentialmanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5b87ef6b-7ed8-434f-ba0e-184fac1628d1")]
public partial interface IMFNetCredentialManager
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialmanager-begingetcredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginGetCredentials(in MFNetCredentialManagerGetParam pParam, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialmanager-endgetcredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndGetCredentials(IMFAsyncResult pResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFNetCredential>))] out IMFNetCredential ppCred);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialmanager-setgood
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGood(IMFNetCredential pCred, BOOL fGood);
}
