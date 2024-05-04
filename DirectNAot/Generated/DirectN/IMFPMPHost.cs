#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpmphost
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f70ca1a9-fdc7-4782-b994-adffb1c98606")]
public partial interface IMFPMPHost
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphost-lockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphost-unlockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphost-createobjectbyclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectByCLSID(in Guid clsid, IStream pStream, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
}
