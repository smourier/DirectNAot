namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1gradientstopcollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a7-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1GradientStopCollection : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gradientstopcollection-getgradientstopcount
    [PreserveSig]
    public uint GetGradientStopCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gradientstopcollection-getgradientstops
    [PreserveSig]
    public void GetGradientStops(out D2D1_GRADIENT_STOP gradientStops, uint gradientStopsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gradientstopcollection-getcolorinterpolationgamma
    [PreserveSig]
    public D2D1_GAMMA GetColorInterpolationGamma();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gradientstopcollection-getextendmode
    [PreserveSig]
    public D2D1_EXTEND_MODE GetExtendMode();
}
