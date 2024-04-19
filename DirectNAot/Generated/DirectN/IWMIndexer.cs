namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmindexer
[GeneratedComInterface, Guid("6d7cdc71-9888-11d3-8edc-00c04f6109cf")]
public partial interface IWMIndexer
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmindexer-startindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartIndexing(PWSTR pwszURL, IWMStatusCallback pCallback, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmindexer-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
