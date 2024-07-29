#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpdvd
[GeneratedComInterface, Guid("8da61686-4668-4a5c-ae5d-803193293dbe")]
public partial interface IWMPDVD : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-get_isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isAvailable(BSTR bstrItem, ref VARIANT_BOOL pIsAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-get_domain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_domain(ref BSTR strDomain);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-topmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT topMenu();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-titlemenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT titleMenu();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-back
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT back();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpdvd-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT resume();
}
