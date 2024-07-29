#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfshutdown
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("97ec2ea4-0e42-4937-97ac-9d6d328824e1")]
public partial interface IMFShutdown
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfshutdown-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfshutdown-getshutdownstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShutdownStatus(out MFSHUTDOWN_STATUS pStatus);
}
