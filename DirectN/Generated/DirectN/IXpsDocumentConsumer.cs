#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4368d8a2-4181-4a9f-b295-3d9a38bb9ba0")]
public partial interface IXpsDocumentConsumer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendXpsUnknown(nint pUnknown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendXpsDocument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsDocument>))] IXpsDocument pIXpsDocument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendFixedDocumentSequence([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFixedDocumentSequence>))] IFixedDocumentSequence pIFixedDocumentSequence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendFixedDocument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFixedDocument>))] IFixedDocument pIFixedDocument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendFixedPage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFixedPage>))] IFixedPage pIFixedPage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseSender();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNewEmptyPart(PWSTR uri, in Guid riid, out nint ppNewObject, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrintWriteStream>))] out IPrintWriteStream ppWriteStream);
}
