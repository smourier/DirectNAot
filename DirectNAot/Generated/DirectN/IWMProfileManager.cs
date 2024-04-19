namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmprofilemanager
[GeneratedComInterface, Guid("d16679f2-6ca0-472d-8d31-2f5d55aee155")]
public partial interface IWMProfileManager
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-createemptyprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEmptyProfile(WMT_VERSION dwVersion, out IWMProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-loadprofilebyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadProfileByID(in Guid guidProfile, out IWMProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-loadprofilebydata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadProfileByData(PWSTR pwszProfile, out IWMProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-saveprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveProfile(IWMProfile pIWMProfile, PWSTR pwszProfile, ref uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-getsystemprofilecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemProfileCount(out uint pcProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanager-loadsystemprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadSystemProfile(uint dwProfileIndex, out IWMProfile ppProfile);
}
