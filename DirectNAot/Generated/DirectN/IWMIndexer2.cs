namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmindexer2
[GeneratedComInterface, Guid("b70f1e42-6255-4df0-a6b9-02b212d9e2bb")]
public partial interface IWMIndexer2 : IWMIndexer
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmindexer2-configure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Configure(ushort wStreamNum, WMT_INDEXER_TYPE nIndexerType, nint pvInterval, nint pvIndexType);
}
