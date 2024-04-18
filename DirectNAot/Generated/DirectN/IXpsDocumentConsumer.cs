namespace DirectN;

[GeneratedComInterface, Guid("4368d8a2-4181-4a9f-b295-3d9a38bb9ba0")]
public partial interface IXpsDocumentConsumer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendXpsUnknown(nint pUnknown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendXpsDocument(IXpsDocument pIXpsDocument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendFixedDocumentSequence(IFixedDocumentSequence pIFixedDocumentSequence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendFixedDocument(IFixedDocument pIFixedDocument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendFixedPage(IFixedPage pIFixedPage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CloseSender();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNewEmptyPart(PWSTR uri, in Guid riid, out nint ppNewObject, out IPrintWriteStream ppWriteStream);
}
