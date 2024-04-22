namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomcolorprofileresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("67bd7d69-1eef-4bb1-b5e7-6f4f87be8abe")]
public partial interface IXpsOMColorProfileResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(out IStream stream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent(IStream sourceStream, IOpcPartUri partName);
}
