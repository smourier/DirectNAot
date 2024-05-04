#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmprofilemanagerlanguage
[GeneratedComInterface, Guid("ba4dcc78-7ee0-4ab8-b27a-dbce8bc51454")]
public partial interface IWMProfileManagerLanguage
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanagerlanguage-getuserlanguageid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserLanguageID(ref ushort wLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofilemanagerlanguage-setuserlanguageid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserLanguageID(ushort wLangID);
}
