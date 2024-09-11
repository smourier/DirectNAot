#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomimageresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3db8417d-ae50-485e-9a44-d7758f78a23f")]
public partial interface IXpsOMImageResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream readerStream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream sourceStream, XPS_IMAGE_TYPE imageType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-getimagetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageType(out XPS_IMAGE_TYPE imageType);
}
