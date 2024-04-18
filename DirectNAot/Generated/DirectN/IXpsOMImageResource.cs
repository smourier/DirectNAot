namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomimageresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3db8417d-ae50-485e-9a44-d7758f78a23f")]
public partial interface IXpsOMImageResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStream(out IStream readerStream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContent(IStream sourceStream, XPS_IMAGE_TYPE imageType, IOpcPartUri partName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimageresource-getimagetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetImageType(out XPS_IMAGE_TYPE imageType);
}
