#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomobjectfactory
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f9b2a685-a50d-4fc2-b764-b56e093ea0ca")]
public partial interface IXpsOMObjectFactory
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackage(out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagefromfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromFile(PWSTR filename, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromStream(IStream stream, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStoryFragmentsResource(IStream acquiredStream, IOpcPartUri partUri, out IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocumentstructureresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocumentStructureResource(IStream acquiredStream, IOpcPartUri partUri, out IXpsOMDocumentStructureResource documentStructureResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createsignatureblockresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSignatureBlockResource(IStream acquiredStream, IOpcPartUri partUri, out IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createremotedictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResource(IXpsOMDictionary dictionary, IOpcPartUri partUri, out IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createremotedictionaryresourcefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResourceFromStream(IStream dictionaryMarkupStream, IOpcPartUri dictionaryPartUri, IXpsOMPartResources resources, out IXpsOMRemoteDictionaryResource dictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpartresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartResources(out IXpsOMPartResources partResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocumentSequence(IOpcPartUri partUri, out IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocument
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocument(IOpcPartUri partUri, out IXpsOMDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpagereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageReference(in XPS_SIZE advisoryPageDimensions, out IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePage(in XPS_SIZE pageDimensions, PWSTR language, IOpcPartUri partUri, out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpagefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageFromStream(IStream pageMarkupStream, IOpcPartUri partUri, IXpsOMPartResources resources, [MarshalAs(UnmanagedType.U4)] bool reuseObjects, out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcanvas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCanvas(out IXpsOMCanvas canvas);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGlyphs(IXpsOMFontResource fontResource, out IXpsOMGlyphs glyphs);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePath(out IXpsOMPath path);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometry(out IXpsOMGeometry geometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategeometryfigure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryFigure(in XPS_POINT startPoint, out IXpsOMGeometryFigure figure);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform(in XPS_MATRIX matrix, out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createsolidcolorbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSolidColorBrush(in XPS_COLOR color, IXpsOMColorProfileResource colorProfile, out IXpsOMSolidColorBrush solidColorBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcolorprofileresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorProfileResource(IStream acquiredStream, IOpcPartUri partUri, out IXpsOMColorProfileResource colorProfileResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createimagebrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageBrush(IXpsOMImageResource image, in XPS_RECT viewBox, in XPS_RECT viewPort, out IXpsOMImageBrush imageBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createvisualbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVisualBrush(in XPS_RECT viewBox, in XPS_RECT viewPort, out IXpsOMVisualBrush visualBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createimageresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageResource(IStream acquiredStream, XPS_IMAGE_TYPE contentType, IOpcPartUri partUri, out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePrintTicketResource(IStream acquiredStream, IOpcPartUri partUri, out IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontResource(IStream acquiredStream, XPS_FONT_EMBEDDING fontEmbedding, IOpcPartUri partUri, [MarshalAs(UnmanagedType.U4)] bool isObfSourceStream, out IXpsOMFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategradientstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGradientStop(in XPS_COLOR color, IXpsOMColorProfileResource colorProfile, float offset, out IXpsOMGradientStop gradientStop);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createlineargradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLinearGradientBrush(IXpsOMGradientStop gradStop1, IXpsOMGradientStop gradStop2, in XPS_POINT startPoint, in XPS_POINT endPoint, out IXpsOMLinearGradientBrush linearGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createradialgradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRadialGradientBrush(IXpsOMGradientStop gradStop1, IXpsOMGradientStop gradStop2, in XPS_POINT centerPoint, in XPS_POINT gradientOrigin, in XPS_SIZE radiiSizes, out IXpsOMRadialGradientBrush radialGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreProperties(IOpcPartUri partUri, out IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDictionary(out IXpsOMDictionary dictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createparturicollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartUriCollection(out IXpsOMPartUriCollection partUriCollection);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagewriteronfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnFile(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagewriteronstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnStream(ISequentialStream outputStream, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize, XPS_INTERLEAVING interleaving, IOpcPartUri documentSequencePartName, IXpsOMCoreProperties coreProperties, IXpsOMImageResource packageThumbnail, IXpsOMPrintTicketResource documentSequencePrintTicket, IOpcPartUri discardControlPartName, out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartUri(PWSTR uri, out IOpcPartUri partUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createreadonlystreamonfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReadOnlyStreamOnFile(PWSTR filename, out IStream stream);
}
