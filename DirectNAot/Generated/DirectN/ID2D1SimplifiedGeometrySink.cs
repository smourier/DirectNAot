namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1simplifiedgeometrysink
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd9069e-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1SimplifiedGeometrySink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-setfillmode
    [PreserveSig]
    public void SetFillMode(D2D1_FILL_MODE fillMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-setsegmentflags
    [PreserveSig]
    public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-beginfigure
    [PreserveSig]
    public void BeginFigure(D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-addlines
    [PreserveSig]
    public void AddLines(in D2D_POINT_2F points, uint pointsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-addbeziers
    [PreserveSig]
    public void AddBeziers(in D2D1_BEZIER_SEGMENT beziers, uint beziersCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-endfigure
    [PreserveSig]
    public void EndFigure(D2D1_FIGURE_END figureEnd);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1simplifiedgeometrysink-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Close();
}
