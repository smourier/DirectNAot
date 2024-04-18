namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompackage
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("18c3df65-81e1-4674-91dc-fc452f5a416f")]
public partial interface IXpsOMPackage
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDocumentSequence(out IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDocumentSequence(IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCoreProperties(out IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCoreProperties(IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getdiscardcontrolpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDiscardControlPartName(out IOpcPartUri discardControlPartUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setdiscardcontrolpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDiscardControlPartName(IOpcPartUri discardControlPartUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-getthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetThumbnailResource(out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-setthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetThumbnailResource(IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-writetofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WriteToFile(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackage-writetostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WriteToStream(ISequentialStream stream, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize);
}
