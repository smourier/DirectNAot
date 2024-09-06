#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfhttpdownloadsession
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("71fa9a2c-53ce-4662-a132-1a7e8cbf62db")]
public partial interface IMFHttpDownloadSession
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadsession-setserver
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetServer(PWSTR szServerName, uint nPort);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadsession-createrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRequest(PWSTR szObjectName, BOOL fBypassProxyCache, BOOL fSecure, PWSTR szVerb, PWSTR szReferrer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFHttpDownloadRequest>))] out IMFHttpDownloadRequest ppRequest);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadsession-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
