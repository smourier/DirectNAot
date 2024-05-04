#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcdromcollection
[GeneratedComInterface, Guid("ee4c8fe2-34b2-11d3-a3bf-006097c9b344")]
public partial interface IWMPCdromCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromcollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromcollection-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(int lIndex, out IWMPCdrom ppItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromcollection-getbydrivespecifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByDriveSpecifier(BSTR bstrDriveSpecifier, out IWMPCdrom ppCdrom);
}
