#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmplibrarysharingservices
[GeneratedComInterface, Guid("82cba86b-9f04-474b-a365-d6dd1466e541")]
public partial interface IWMPLibrarySharingServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrarysharingservices-islibraryshared
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isLibraryShared(ref VARIANT_BOOL pvbShared);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrarysharingservices-islibrarysharingenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isLibrarySharingEnabled(ref VARIANT_BOOL pvbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrarysharingservices-showlibrarysharing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT showLibrarySharing();
}
