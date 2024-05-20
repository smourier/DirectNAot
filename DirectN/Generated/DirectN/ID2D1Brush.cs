#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1brush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a8-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1Brush : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1brush-setopacity
    [PreserveSig]
    void SetOpacity(float opacity);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1brush-settransform
    [PreserveSig]
    void SetTransform(in D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1brush-getopacity
    [PreserveSig]
    float GetOpacity();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1brush-gettransform
    [PreserveSig]
    void GetTransform(out D2D_MATRIX_3X2_F transform);
}
