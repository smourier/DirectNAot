namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmprofilemanager2
[GeneratedComInterface, Guid("7a924e51-73c1-494d-8019-23d37ed9b89a")]
public partial interface IWMProfileManager2 : IWMProfileManager
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager2-getsystemprofileversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemProfileVersion(ref WMT_VERSION pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager2-setsystemprofileversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSystemProfileVersion(WMT_VERSION dwVersion);
}
