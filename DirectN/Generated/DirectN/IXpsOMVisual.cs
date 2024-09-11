#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomvisual
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("bc3e7333-fb0b-4af3-a819-0b4eaad0d2fd")]
public partial interface IXpsOMVisual : IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-settransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-settransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipGeometryLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setclipgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipGeometryLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipGeometryLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setclipgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipGeometryLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpacity(out float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacity(float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpacityMaskBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpacityMaskBrushLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacitymaskbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacityMaskBrushLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpacityMaskBrushLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacitymaskbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacityMaskBrushLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetName(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsHyperlinkTarget(out BOOL isHyperlink);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsHyperlinkTarget(BOOL isHyperlink);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gethyperlinknavigateuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHyperlinkNavigateUri([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] out IUri hyperlinkUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-sethyperlinknavigateuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHyperlinkNavigateUri([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri hyperlinkUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(out PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLanguage(PWSTR language);
}
