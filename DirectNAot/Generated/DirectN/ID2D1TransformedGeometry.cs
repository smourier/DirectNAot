namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1transformedgeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906bb-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1TransformedGeometry : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1transformedgeometry-getsourcegeometry
    [PreserveSig]
    public void GetSourceGeometry(out ID2D1Geometry sourceGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1transformedgeometry-gettransform
    [PreserveSig]
    public void GetTransform(out D2D_MATRIX_3X2_F transform);
}
