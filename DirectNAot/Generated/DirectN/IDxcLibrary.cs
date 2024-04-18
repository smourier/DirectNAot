namespace DirectN;

[GeneratedComInterface, Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
public partial interface IDxcLibrary
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMalloc(IMalloc pMalloc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobFromBlob(IDxcBlob pBlob, uint offset, uint length, out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobFromFile(PWSTR pFileName, nint/* nint */ codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobWithEncodingFromPinned(nint pText, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobWithEncodingOnHeapCopy(nint pText, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobWithEncodingOnMalloc(nint pText, IMalloc pIMalloc, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateIncludeHandler(out IDxcIncludeHandler ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateStreamFromBlobReadOnly(IDxcBlob pBlob, out IStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBlobAsUtf8(IDxcBlob pBlob, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBlobAsUtf16(IDxcBlob pBlob, out IDxcBlobEncoding pBlobEncoding);
}
