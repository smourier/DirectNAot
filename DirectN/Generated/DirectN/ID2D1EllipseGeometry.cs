#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1ellipsegeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a4-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1EllipseGeometry : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1ellipsegeometry-getellipse
    [PreserveSig]
    void GetEllipse(out D2D1_ELLIPSE ellipse);
}
