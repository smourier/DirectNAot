namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1roundedrectanglegeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a3-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1RoundedRectangleGeometry : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1roundedrectanglegeometry-getroundedrect
    [PreserveSig]
    void GetRoundedRect(out D2D1_ROUNDED_RECT roundedRect);
}
