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
    HRESULT CreatePackage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage>))] out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagefromfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromFile(PWSTR filename, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage>))] out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageFromStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream stream, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackage>))] out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStoryFragmentsResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMStoryFragmentsResource>))] out IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocumentstructureresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocumentStructureResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocumentStructureResource>))] out IXpsOMDocumentStructureResource documentStructureResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createsignatureblockresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSignatureBlockResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] out IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createremotedictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] IXpsOMDictionary dictionary, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRemoteDictionaryResource>))] out IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createremotedictionaryresourcefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteDictionaryResourceFromStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream dictionaryMarkupStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri dictionaryPartUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartResources>))] IXpsOMPartResources resources, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRemoteDictionaryResource>))] out IXpsOMRemoteDictionaryResource dictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpartresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartResources>))] out IXpsOMPartResources partResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocumentsequence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocumentSequence([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocumentSequence>))] out IXpsOMDocumentSequence documentSequence);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdocument
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocument>))] out IXpsOMDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpagereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageReference(in XPS_SIZE advisoryPageDimensions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPageReference>))] out IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePage(in XPS_SIZE pageDimensions, PWSTR language, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpagefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePageFromStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pageMarkupStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartResources>))] IXpsOMPartResources resources, BOOL reuseObjects, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcanvas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCanvas([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMCanvas>))] out IXpsOMCanvas canvas);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGlyphs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMFontResource>))] IXpsOMFontResource fontResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGlyphs>))] out IXpsOMGlyphs glyphs);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePath([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPath>))] out IXpsOMPath path);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry geometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategeometryfigure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryFigure(in XPS_POINT startPoint, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometryFigure>))] out IXpsOMGeometryFigure figure);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform(in XPS_MATRIX matrix, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createsolidcolorbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSolidColorBrush(in XPS_COLOR color, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] IXpsOMColorProfileResource colorProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSolidColorBrush>))] out IXpsOMSolidColorBrush solidColorBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcolorprofileresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorProfileResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] out IXpsOMColorProfileResource colorProfileResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createimagebrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource image, in XPS_RECT viewBox, in XPS_RECT viewPort, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageBrush>))] out IXpsOMImageBrush imageBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createvisualbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVisualBrush(in XPS_RECT viewBox, in XPS_RECT viewPort, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisualBrush>))] out IXpsOMVisualBrush visualBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createimageresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, XPS_IMAGE_TYPE contentType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePrintTicketResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] out IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream acquiredStream, XPS_FONT_EMBEDDING fontEmbedding, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, BOOL isObfSourceStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMFontResource>))] out IXpsOMFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-creategradientstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGradientStop(in XPS_COLOR color, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] IXpsOMColorProfileResource colorProfile, float offset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGradientStop>))] out IXpsOMGradientStop gradientStop);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createlineargradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLinearGradientBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGradientStop>))] IXpsOMGradientStop gradStop1, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGradientStop>))] IXpsOMGradientStop gradStop2, in XPS_POINT startPoint, in XPS_POINT endPoint, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMLinearGradientBrush>))] out IXpsOMLinearGradientBrush linearGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createradialgradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRadialGradientBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGradientStop>))] IXpsOMGradientStop gradStop1, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGradientStop>))] IXpsOMGradientStop gradStop2, in XPS_POINT centerPoint, in XPS_POINT gradientOrigin, in XPS_SIZE radiiSizes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRadialGradientBrush>))] out IXpsOMRadialGradientBrush radialGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createcoreproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMCoreProperties>))] out IXpsOMCoreProperties coreProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDictionary([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] out IXpsOMDictionary dictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createparturicollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartUriCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartUriCollection>))] out IXpsOMPartUriCollection partUriCollection);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagewriteronfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnFile(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, BOOL optimizeMarkupSize, XPS_INTERLEAVING interleaving, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri documentSequencePartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMCoreProperties>))] IXpsOMCoreProperties coreProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource packageThumbnail, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource documentSequencePrintTicket, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri discardControlPartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createpackagewriteronstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePackageWriterOnStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISequentialStream>))] ISequentialStream outputStream, BOOL optimizeMarkupSize, XPS_INTERLEAVING interleaving, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri documentSequencePartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMCoreProperties>))] IXpsOMCoreProperties coreProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource packageThumbnail, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource documentSequencePrintTicket, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri discardControlPartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePartUri(PWSTR uri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri partUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomobjectfactory-createreadonlystreamonfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReadOnlyStreamOnFile(PWSTR filename, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream stream);
}
