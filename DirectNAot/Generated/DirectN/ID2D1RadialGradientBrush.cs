namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1radialgradientbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906ac-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1RadialGradientBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-setcenter
    [PreserveSig]
    public void SetCenter(D2D_POINT_2F center);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-setgradientoriginoffset
    [PreserveSig]
    public void SetGradientOriginOffset(D2D_POINT_2F gradientOriginOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-setradiusx
    [PreserveSig]
    public void SetRadiusX(float radiusX);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-setradiusy
    [PreserveSig]
    public void SetRadiusY(float radiusY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-getcenter
    [PreserveSig]
    public D2D_POINT_2F GetCenter();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-getgradientoriginoffset
    [PreserveSig]
    public D2D_POINT_2F GetGradientOriginOffset();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-getradiusx
    [PreserveSig]
    public float GetRadiusX();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-getradiusy
    [PreserveSig]
    public float GetRadiusY();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1radialgradientbrush-getgradientstopcollection
    [PreserveSig]
    public void GetGradientStopCollection(out ID2D1GradientStopCollection gradientStopCollection);
}
