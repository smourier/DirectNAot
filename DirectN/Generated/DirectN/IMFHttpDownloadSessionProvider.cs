#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfhttpdownloadsessionprovider
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("1b4cf4b9-3a16-4115-839d-03cc5c99df01")]
public partial interface IMFHttpDownloadSessionProvider
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadsessionprovider-createhttpdownloadsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHttpDownloadSession(PWSTR wszScheme, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFHttpDownloadSession>))] out IMFHttpDownloadSession ppDownloadSession);
}
