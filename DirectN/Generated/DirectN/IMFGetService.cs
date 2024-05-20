#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfgetservice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fa993888-4383-415a-a930-dd472a8cf6f7")]
public partial interface IMFGetService
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfgetservice-getservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetService(in Guid guidService, in Guid riid, out nint /* void */ ppvObject);
}
