#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfextendedcameracontrol
[GeneratedComInterface, Guid("38e33520-fca1-4845-a27a-68b7c6ab3789")]
public partial interface IMFExtendedCameraControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-getcapabilities
    [PreserveSig]
    ulong GetCapabilities();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(ulong ulFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-getflags
    [PreserveSig]
    ulong GetFlags();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-lockpayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockPayload(out nint /* byte array */ ppPayload, out uint pulPayload);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-unlockpayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockPayload();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontrol-commitsettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitSettings();
}
