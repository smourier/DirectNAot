namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1rectanglegeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a2-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1RectangleGeometry : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rectanglegeometry-getrect
    [PreserveSig]
    public void GetRect(out D2D_RECT_F rect);
}
