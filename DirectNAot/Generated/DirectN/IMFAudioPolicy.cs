#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfaudiopolicy
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a0638c2b-6465-4395-9ae7-a321a9fd2856")]
public partial interface IMFAudioPolicy
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-setgroupingparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupingParam(in Guid rguidClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-getgroupingparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupingParam(out Guid pguidClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-setdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplayName(PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(out PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-seticonpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconPath(PWSTR pszPath);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiopolicy-geticonpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconPath(out PWSTR pszPath);
}
