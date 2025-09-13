#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmetadatatext
[GeneratedComInterface, Guid("769a72db-13d2-45e2-9c48-53ca9d5b7450")]
public partial interface IWMPMetadataText : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatatext-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_description(out BSTR pbstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatatext-get_text
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_text(out BSTR pbstrText);
}
