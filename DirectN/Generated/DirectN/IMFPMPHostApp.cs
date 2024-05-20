#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpmphostapp
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("84d2054a-3aa1-4728-a3b0-440a418cf49c")]
public partial interface IMFPMPHostApp
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphostapp-lockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphostapp-unlockprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockProcess();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmphostapp-activateclassbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateClassById(PWSTR id, IStream pStream, in Guid riid, out nint /* void */ ppv);
}
