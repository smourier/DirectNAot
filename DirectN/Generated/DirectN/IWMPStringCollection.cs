#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpstringcollection
[GeneratedComInterface, Guid("4a976298-8c0d-11d3-b389-00c04f68574b")]
public partial interface IWMPStringCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(int lIndex, ref BSTR pbstrString);
}
