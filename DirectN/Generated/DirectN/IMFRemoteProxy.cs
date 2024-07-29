#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfremoteproxy
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("994e23ad-1cc2-493c-b9fa-46f1cb040fa4")]
public partial interface IMFRemoteProxy
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfremoteproxy-getremoteobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRemoteObject(in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfremoteproxy-getremotehost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRemoteHost(in Guid riid, out nint ppv);
}
