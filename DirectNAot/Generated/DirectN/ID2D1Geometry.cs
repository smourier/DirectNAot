namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1geometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a1-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1Geometry : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-getbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBounds(nint/* nint */ worldTransform, out D2D_RECT_F bounds);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-getwidenedbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle strokeStyle, nint/* nint */ worldTransform, float flatteningTolerance, out D2D_RECT_F bounds);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-strokecontainspoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle strokeStyle, nint/* nint */ worldTransform, float flatteningTolerance, [MarshalAs(UnmanagedType.U4)] out bool contains);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-fillcontainspoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FillContainsPoint(D2D_POINT_2F point, nint/* nint */ worldTransform, float flatteningTolerance, [MarshalAs(UnmanagedType.U4)] out bool contains);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-comparewithgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareWithGeometry(ID2D1Geometry inputGeometry, nint/* nint */ inputGeometryTransform, float flatteningTolerance, out D2D1_GEOMETRY_RELATION relation);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-simplify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, nint/* nint */ worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-tessellate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Tessellate(nint/* nint */ worldTransform, float flatteningTolerance, ID2D1TessellationSink tessellationSink);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-combinewithgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CombineWithGeometry(ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, nint/* nint */ inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-outline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Outline(nint/* nint */ worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-computearea
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeArea(nint/* nint */ worldTransform, float flatteningTolerance, out float area);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-computelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeLength(nint/* nint */ worldTransform, float flatteningTolerance, out float length);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-computepointatlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputePointAtLength(float length, nint/* nint */ worldTransform, float flatteningTolerance, nint/* nint */ point, nint/* nint */ unitTangentVector);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometry-widen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Widen(float strokeWidth, ID2D1StrokeStyle strokeStyle, nint/* nint */ worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
}
