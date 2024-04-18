namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1ink
[GeneratedComInterface, Guid("b499923b-7029-478f-a8b3-432c7c5f5312")]
public partial interface ID2D1Ink : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-setstartpoint(constd2d1_ink_point)
    [PreserveSig]
    public void SetStartPoint(in D2D1_INK_POINT startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-getstartpoint
    [PreserveSig]
    public D2D1_INK_POINT GetStartPoint();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-addsegments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddSegments(in D2D1_INK_BEZIER_SEGMENT segments, uint segmentsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-removesegmentsatend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveSegmentsAtEnd(uint segmentsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-setsegments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSegments(uint startSegment, in D2D1_INK_BEZIER_SEGMENT segments, uint segmentsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-setsegmentatend(constd2d1_ink_bezier_segment)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSegmentAtEnd(in D2D1_INK_BEZIER_SEGMENT segment);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-getsegmentcount
    [PreserveSig]
    public uint GetSegmentCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-getsegments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSegments(uint startSegment, out D2D1_INK_BEZIER_SEGMENT segments, uint segmentsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-streamasgeometry(id2d1inkstyle_constd2d1_matrix_3x2_f__float_id2d1simplifiedgeometrysink)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StreamAsGeometry(ID2D1InkStyle inkStyle, nint /* D2D_MATRIX_3X2_F */ worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1ink-getbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBounds(ID2D1InkStyle inkStyle, nint /* D2D_MATRIX_3X2_F */ worldTransform, out D2D_RECT_F bounds);
}
