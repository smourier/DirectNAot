#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1geometrysink
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd9069f-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1GeometrySink : ID2D1SimplifiedGeometrySink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1geometrysink-addline
    [PreserveSig]
    void AddLine(D2D_POINT_2F point);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometrysink-addbezier
    [PreserveSig]
    void AddBezier(in D2D1_BEZIER_SEGMENT bezier);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometrysink-addquadraticbezier
    [PreserveSig]
    void AddQuadraticBezier(in D2D1_QUADRATIC_BEZIER_SEGMENT bezier);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1geometrysink-addquadraticbeziers
    [PreserveSig]
    void AddQuadraticBeziers([MarshalUsing(CountElementName = nameof(beziersCount))] in D2D1_QUADRATIC_BEZIER_SEGMENT[] beziers, uint beziersCount);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1geometrysink-addarc
    [PreserveSig]
    void AddArc(in D2D1_ARC_SEGMENT arc);
}
