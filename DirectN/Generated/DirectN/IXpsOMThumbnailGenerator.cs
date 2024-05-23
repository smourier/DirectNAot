#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomthumbnailgenerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("15b873d5-1971-41e8-83a3-6578403064c7")]
public partial interface IXpsOMThumbnailGenerator
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomthumbnailgenerator-generatethumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateThumbnail(IXpsOMPage page, XPS_IMAGE_TYPE thumbnailType, XPS_THUMBNAIL_SIZE thumbnailSize, IOpcPartUri imageResourcePartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] out IXpsOMImageResource imageResource);
}
