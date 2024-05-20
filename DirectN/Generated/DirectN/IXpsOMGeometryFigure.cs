#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomgeometryfigure
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d410dc83-908c-443e-8947-b1795d3c165a")]
public partial interface IXpsOMGeometryFigure
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner(out IXpsOMGeometry owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmentdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentData(ref uint dataCount, ref float segmentData);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentTypes(ref uint segmentCount, ref XPS_SEGMENT_TYPE segmentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmentstrokes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentStrokes(ref uint segmentCount, [MarshalAs(UnmanagedType.U4)] ref bool segmentStrokes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-setsegments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSegments(uint segmentCount, uint segmentDataCount, [In][Out][MarshalUsing(CountElementName = nameof(segmentCount))] XPS_SEGMENT_TYPE[] segmentTypes, [In][Out][MarshalUsing(CountElementName = nameof(segmentDataCount))] float[] segmentData, [In][Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] bool[] segmentStrokes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getstartpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartPoint(out XPS_POINT startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-setstartpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStartPoint(in XPS_POINT startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getisclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsClosed([MarshalAs(UnmanagedType.U4)] out bool isClosed);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-setisclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsClosed([MarshalAs(UnmanagedType.U4)] bool isClosed);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getisfilled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsFilled([MarshalAs(UnmanagedType.U4)] out bool isFilled);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-setisfilled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsFilled([MarshalAs(UnmanagedType.U4)] bool isFilled);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentCount(out uint segmentCount);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmentdatacount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentDataCount(out uint segmentDataCount);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-getsegmentstrokepattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentStrokePattern(out XPS_SEGMENT_STROKE_PATTERN segmentStrokePattern);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometryfigure-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IXpsOMGeometryFigure geometryFigure);
}
