#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomdocumentsequence
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("56492eb4-d8d5-425e-8256-4c2b64ad0264")]
public partial interface IXpsOMDocumentSequence : IXpsOMPart
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentsequence-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage>))] out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentsequence-getdocuments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocuments([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocumentCollection>))] out IXpsOMDocumentCollection documents);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentsequence-getprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrintTicketResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] out IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentsequence-setprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrintTicketResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource printTicketResource);
}
