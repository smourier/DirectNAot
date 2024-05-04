#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmplibrary2
[GeneratedComInterface, Guid("dd578a4e-79b1-426c-bf8f-3add9072500b")]
public partial interface IWMPLibrary2 : IWMPLibrary
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibrary2-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrItemName, ref BSTR pbstrVal);
}
