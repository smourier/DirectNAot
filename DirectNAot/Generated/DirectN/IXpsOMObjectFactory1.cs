namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nn-xpsobjectmodel_1-ixpsomobjectfactory1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0a91b617-d612-4181-bf7c-be5824e9cc8f")]
public partial interface IXpsOMObjectFactory1 : IXpsOMObjectFactory
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-getdocumenttypefromfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentTypeFromFile(PWSTR filename, out XPS_DOCUMENT_TYPE documentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-getdocumenttypefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentTypeFromStream(IStream xpsDocumentStream, out XPS_DOCUMENT_TYPE documentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-converthdphototojpegxr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertHDPhotoToJpegXR(IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-convertjpegxrtohdphoto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertJpegXRToHDPhoto(IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagewriteronfile1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnFile1(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, XPS_DOCUMENT_TYPE documentType, out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagewriteronstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnStream1(ISequentialStream outputStream, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, XPS_DOCUMENT_TYPE documentType, out IXpsOMPackageWriter packageWriter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackage1(out IXpsOMPackage1 package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromStream1(IStream stream, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPackage1 package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagefromfile1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromFile1(PWSTR filename, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPackage1 package);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePage1(in XPS_SIZE pageDimensions, PWSTR language, IOpcPartUri partUri, out IXpsOMPage1 page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpagefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageFromStream1(IStream pageMarkupStream, IOpcPartUri partUri, IXpsOMPartResources resources, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPage1 page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createremotedictionaryresourcefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResourceFromStream1(IStream dictionaryMarkupStream, IOpcPartUri partUri, IXpsOMPartResources resources, out IXpsOMRemoteDictionaryResource dictionaryResource);
}
