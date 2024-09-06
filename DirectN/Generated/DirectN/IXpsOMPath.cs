#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompath
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("37d38bb6-3ee9-4110-9312-14b194163337")]
public partial interface IXpsOMPath : IXpsOMVisual
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry geometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeometryLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry geometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setgeometrylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGeometryLocal(IXpsOMGeometry geometry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeometryLookup(out PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setgeometrylookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGeometryLookup(PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getaccessibilityshortdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessibilityShortDescription(out PWSTR shortDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setaccessibilityshortdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccessibilityShortDescription(PWSTR shortDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getaccessibilitylongdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessibilityLongDescription(out PWSTR longDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setaccessibilitylongdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccessibilityLongDescription(PWSTR longDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getsnapstopixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSnapsToPixels(out BOOL snapsToPixels);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setsnapstopixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSnapsToPixels(BOOL snapsToPixels);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokebrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokebrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeBrushLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokebrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeBrushLocal(IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokebrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeBrushLookup(out PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokebrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeBrushLookup(PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokedashes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeDashes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDashCollection>))] out IXpsOMDashCollection strokeDashes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokedashcap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeDashCap(out XPS_DASH_CAP strokeDashCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokedashcap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeDashCap(XPS_DASH_CAP strokeDashCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokedashoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeDashOffset(out float strokeDashOffset);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokedashoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeDashOffset(float strokeDashOffset);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokestartlinecap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeStartLineCap(out XPS_LINE_CAP strokeStartLineCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokestartlinecap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeStartLineCap(XPS_LINE_CAP strokeStartLineCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokeendlinecap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeEndLineCap(out XPS_LINE_CAP strokeEndLineCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokeendlinecap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeEndLineCap(XPS_LINE_CAP strokeEndLineCap);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokelinejoin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeLineJoin(out XPS_LINE_JOIN strokeLineJoin);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokelinejoin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeLineJoin(XPS_LINE_JOIN strokeLineJoin);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokemiterlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeMiterLimit(out float strokeMiterLimit);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokemiterlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeMiterLimit(float strokeMiterLimit);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getstrokethickness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrokeThickness(out float strokeThickness);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setstrokethickness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrokeThickness(float strokeThickness);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getfillbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFillBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getfillbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFillBrushLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMBrush>))] out IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setfillbrushlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFillBrushLocal(IXpsOMBrush brush);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-getfillbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFillBrushLookup(out PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-setfillbrushlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFillBrushLookup(PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompath-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPath>))] out IXpsOMPath path);
}
