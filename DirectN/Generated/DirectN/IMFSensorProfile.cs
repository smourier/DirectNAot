#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensorprofile
[SupportedOSPlatform("windows10.0.17134")]
[GeneratedComInterface, Guid("22f765d1-8dab-4107-846d-56baf72215e7")]
public partial interface IMFSensorProfile
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofile-getprofileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfileId(out SENSORPROFILEID pId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofile-addprofilefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProfileFilter(uint StreamId, PWSTR wzFilterSetString);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofile-ismediatypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMediaTypeSupported(uint StreamId, IMFMediaType pMediaType, [MarshalAs(UnmanagedType.U4)] out bool pfSupported);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofile-addblockedcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBlockedControl(PWSTR wzBlockedControl);
}
