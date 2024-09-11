#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompackagewriter
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("4e2aa182-a443-42c6-b41b-4f8e9de73ff9")]
public partial interface IXpsOMPackageWriter
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-startnewdocument
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartNewDocument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri documentPartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource documentPrintTicket, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocumentStructureResource>))] IXpsOMDocumentStructureResource documentStructure, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResourceCollection>))] IXpsOMSignatureBlockResourceCollection signatureBlockResources, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartUriCollection>))] IXpsOMPartUriCollection restrictedFonts);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-addpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] IXpsOMPage page, in XPS_SIZE advisoryPageDimensions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartUriCollection>))] IXpsOMPartUriCollection discardableResourceParts, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMStoryFragmentsResource>))] IXpsOMStoryFragmentsResource storyFragments, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource pagePrintTicket, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource pageThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-addresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMResource>))] IXpsOMResource resource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-isclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsClosed(out BOOL isClosed);
}
