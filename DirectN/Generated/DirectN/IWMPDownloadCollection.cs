#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0a319c7f-85f9-436c-b88e-82fd88000e1c")]
public partial interface IWMPDownloadCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_id(ref int plId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(int lItem, out IWMPDownloadItem2 ppDownload);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startDownload(BSTR bstrSourceURL, BSTR bstrType, out IWMPDownloadItem2 ppDownload);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT removeItem(int lItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
