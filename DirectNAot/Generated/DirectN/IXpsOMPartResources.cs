namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompartresources
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f4cf7729-4864-4275-99b3-a8717163ecaf")]
public partial interface IXpsOMPartResources
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getfontresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontResources(out IXpsOMFontResourceCollection fontResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getimageresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageResources(out IXpsOMImageResourceCollection imageResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getcolorprofileresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorProfileResources(out IXpsOMColorProfileResourceCollection colorProfileResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getremotedictionaryresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRemoteDictionaryResources(out IXpsOMRemoteDictionaryResourceCollection dictionaryResources);
}
