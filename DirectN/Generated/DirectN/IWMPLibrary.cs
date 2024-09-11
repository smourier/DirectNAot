#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmplibrary
[GeneratedComInterface, Guid("3df47861-7df1-4c1f-a81b-4c26f0f7a7c6")]
public partial interface IWMPLibrary
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrary-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_name(ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrary-get_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_type(ref WMPLibraryType pwmplt);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrary-get_mediacollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_mediaCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMediaCollection>))] out IWMPMediaCollection ppIWMPMediaCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrary-isidentical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isIdentical([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPLibrary>))] IWMPLibrary pIWMPLibrary, ref VARIANT_BOOL pvbool);
}
