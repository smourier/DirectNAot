namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomvisual
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("bc3e7333-fb0b-4af3-a819-0b4eaad0d2fd")]
public partial interface IXpsOMVisual : IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTransform(out IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTransformLocal(out IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-settransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransformLocal(IXpsOMMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gettransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTransformLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-settransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransformLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClipGeometry(out IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClipGeometryLocal(out IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setclipgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClipGeometryLocal(IXpsOMGeometry clipGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getclipgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClipGeometryLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setclipgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClipGeometryLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOpacity(out float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOpacity(float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOpacityMaskBrush(out IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOpacityMaskBrushLocal(out IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacitymaskbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOpacityMaskBrushLocal(IXpsOMBrush opacityMaskBrush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getopacitymaskbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOpacityMaskBrushLookup(out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setopacitymaskbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOpacityMaskBrushLookup(PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetName(out PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetName(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetIsHyperlinkTarget([MarshalAs(UnmanagedType.U4)] out bool isHyperlink);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetIsHyperlinkTarget([MarshalAs(UnmanagedType.U4)] bool isHyperlink);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-gethyperlinknavigateuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHyperlinkNavigateUri(out IUri hyperlinkUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-sethyperlinknavigateuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetHyperlinkNavigateUri(IUri hyperlinkUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLanguage(out PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisual-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLanguage(PWSTR language);
}
