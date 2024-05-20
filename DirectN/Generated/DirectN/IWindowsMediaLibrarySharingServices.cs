#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/nn-wmlss-iwindowsmedialibrarysharingservices
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("01f5f85e-0a81-40da-a7c8-21ef3af8440c")]
public partial interface IWindowsMediaLibrarySharingServices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-showsharemediacpl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT showShareMediaCPL(BSTR device);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_userhomemediasharingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_userHomeMediaSharingState(out VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_userhomemediasharingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_userHomeMediaSharingState(VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_userhomemediasharinglibraryname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_userHomeMediaSharingLibraryName(out BSTR libraryName);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_userhomemediasharinglibraryname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_userHomeMediaSharingLibraryName(BSTR libraryName);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_computerhomemediasharingallowedstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_computerHomeMediaSharingAllowedState(out VARIANT_BOOL sharingAllowed);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_computerhomemediasharingallowedstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_computerHomeMediaSharingAllowedState(VARIANT_BOOL sharingAllowed);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_userinternetmediasharingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_userInternetMediaSharingState(out VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_userinternetmediasharingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_userInternetMediaSharingState(VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_computerinternetmediasharingallowedstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_computerInternetMediaSharingAllowedState(out VARIANT_BOOL sharingAllowed);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_computerinternetmediasharingallowedstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_computerInternetMediaSharingAllowedState(VARIANT_BOOL sharingAllowed);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_internetmediasharingsecuritygroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_internetMediaSharingSecurityGroup(out BSTR securityGroup);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_internetmediasharingsecuritygroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_internetMediaSharingSecurityGroup(BSTR securityGroup);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_allowsharingtoalldevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_allowSharingToAllDevices(out VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-put_allowsharingtoalldevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_allowSharingToAllDevices(VARIANT_BOOL sharingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-setdefaultauthorization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setDefaultAuthorization(BSTR MACAddresses, BSTR friendlyName, VARIANT_BOOL authorization);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-setauthorizationstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setAuthorizationState(BSTR MACAddress, VARIANT_BOOL authorizationState);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-getalldevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAllDevices(out IWindowsMediaLibrarySharingDevices devices);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingservices-get_customsettingsapplied
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_customSettingsApplied(out VARIANT_BOOL customSettingsApplied);
}
