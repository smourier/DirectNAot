namespace DirectN;

[GeneratedComInterface, Guid("cedb484a-d4e9-445a-b991-ca21ca157dc2")]
public partial interface IDxcOperationResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStatus([MarshalAs(UnmanagedType.Error)] out HRESULT pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResult(out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetErrorBuffer(out IDxcBlobEncoding ppErrors);
}
