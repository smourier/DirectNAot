namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1gradientstopcollection1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ae1572f4-5dd0-4777-998b-9279472ae63b")]
public partial interface ID2D1GradientStopCollection1 : ID2D1GradientStopCollection
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getgradientstops1
    [PreserveSig]
    public void GetGradientStops1(out D2D1_GRADIENT_STOP gradientStops, uint gradientStopsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getpreinterpolationspace
    [PreserveSig]
    public D2D1_COLOR_SPACE GetPreInterpolationSpace();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getpostinterpolationspace
    [PreserveSig]
    public D2D1_COLOR_SPACE GetPostInterpolationSpace();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getbufferprecision
    [PreserveSig]
    public D2D1_BUFFER_PRECISION GetBufferPrecision();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getcolorinterpolationmode
    [PreserveSig]
    public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode();
}
