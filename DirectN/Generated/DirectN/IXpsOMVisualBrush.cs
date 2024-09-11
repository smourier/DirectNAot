#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomvisualbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("97e294af-5b37-46b4-8057-874d2f64119b")]
public partial interface IXpsOMVisualBrush : IXpsOMTileBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-getvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisual>))] out IXpsOMVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-getvisuallocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisualLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisual>))] out IXpsOMVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-setvisuallocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVisualLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisual>))] IXpsOMVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-getvisuallookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisualLookup(out PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-setvisuallookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVisualLookup(PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomvisualbrush-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisualBrush>))] out IXpsOMVisualBrush visualBrush);
}
