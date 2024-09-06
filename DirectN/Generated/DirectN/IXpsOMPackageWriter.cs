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
    HRESULT StartNewDocument(IOpcPartUri documentPartName, IXpsOMPrintTicketResource documentPrintTicket, IXpsOMDocumentStructureResource documentStructure, IXpsOMSignatureBlockResourceCollection signatureBlockResources, IXpsOMPartUriCollection restrictedFonts);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-addpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPage(IXpsOMPage page, in XPS_SIZE advisoryPageDimensions, IXpsOMPartUriCollection discardableResourceParts, IXpsOMStoryFragmentsResource storyFragments, IXpsOMPrintTicketResource pagePrintTicket, IXpsOMImageResource pageThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-addresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddResource(IXpsOMResource resource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagewriter-isclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsClosed(out BOOL isClosed);
}
