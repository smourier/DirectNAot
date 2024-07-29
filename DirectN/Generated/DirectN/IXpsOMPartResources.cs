#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompartresources
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f4cf7729-4864-4275-99b3-a8717163ecaf")]
public partial interface IXpsOMPartResources
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getfontresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMFontResourceCollection>))] out IXpsOMFontResourceCollection fontResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getimageresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResourceCollection>))] out IXpsOMImageResourceCollection imageResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getcolorprofileresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorProfileResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResourceCollection>))] out IXpsOMColorProfileResourceCollection colorProfileResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompartresources-getremotedictionaryresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRemoteDictionaryResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRemoteDictionaryResourceCollection>))] out IXpsOMRemoteDictionaryResourceCollection dictionaryResources);
}
