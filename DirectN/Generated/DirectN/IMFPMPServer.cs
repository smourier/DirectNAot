#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpmpserver
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("994e23af-1cc2-493c-b9fa-46f1cb040fa4")]
public partial interface IMFPMPServer
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmpserver-lockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmpserver-unlockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmpserver-createobjectbyclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectByCLSID(in Guid clsid, in Guid riid, out nint /* void */ ppObject);
}
