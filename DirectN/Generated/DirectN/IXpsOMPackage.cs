#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompackage
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("18c3df65-81e1-4674-91dc-fc452f5a416f")]
public partial interface IXpsOMPackage
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentSequence([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocumentSequence>))] out IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDocumentSequence(IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCoreProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMCoreProperties>))] out IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCoreProperties(IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getdiscardcontrolpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDiscardControlPartName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri discardControlPartUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setdiscardcontrolpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDiscardControlPartName(IOpcPartUri discardControlPartUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnailResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnailResource(IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-writetofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteToFile(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, BOOL optimizeMarkupSize);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-writetostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteToStream(ISequentialStream stream, BOOL optimizeMarkupSize);
}
