#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomtilebrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0fc2328d-d722-4a54-b2ec-be90218a789e")]
public partial interface IXpsOMTileBrush : IXpsOMBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-gettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-gettransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-settransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-gettransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-settransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-getviewbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewbox(out XPS_RECT viewbox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-setviewbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewbox(in XPS_RECT viewbox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-getviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewport(out XPS_RECT viewport);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-setviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewport(in XPS_RECT viewport);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-gettilemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTileMode(out XPS_TILE_MODE tileMode);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomtilebrush-settilemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTileMode(XPS_TILE_MODE tileMode);
}
