#nullable enable
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
    HRESULT CreatePackageWriterOnFile1(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, BOOL optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, XPS_DOCUMENT_TYPE documentType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagewriteronstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnStream1(ISequentialStream outputStream, BOOL optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, XPS_DOCUMENT_TYPE documentType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackage1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage1>))] out IXpsOMPackage1 package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromStream1(IStream stream, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage1>))] out IXpsOMPackage1 package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpackagefromfile1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromFile1(PWSTR filename, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage1>))] out IXpsOMPackage1 package);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePage1(in XPS_SIZE pageDimensions, PWSTR language, IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage1>))] out IXpsOMPage1 page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createpagefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageFromStream1(IStream pageMarkupStream, IOpcPartUri partUri, IXpsOMPartResources resources, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage1>))] out IXpsOMPage1 page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomobjectfactory1-createremotedictionaryresourcefromstream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResourceFromStream1(IStream dictionaryMarkupStream, IOpcPartUri partUri, IXpsOMPartResources resources, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRemoteDictionaryResource>))] out IXpsOMRemoteDictionaryResource dictionaryResource);
}
