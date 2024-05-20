#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1solidcolorbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a9-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1SolidColorBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1solidcolorbrush-setcolor
    [PreserveSig]
    void SetColor(in D3DCOLORVALUE color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1solidcolorbrush-getcolor
    [PreserveSig]
    D3DCOLORVALUE GetColor();
}
