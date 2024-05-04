namespace DirectN;

public partial struct SIZE
{
    public SIZE(uint cx, uint cy)
    {
        this.cx = (int)cx;
        this.cy = (int)cy;
    }

    public SIZE(int cx, int cy)
    {
        this.cx = cx;
        this.cy = cy;
    }

    public readonly bool IsZero => cx == 0 && cy == 0;
    public readonly bool IsEmpty => cx == 0 || cy == 0;

    public override readonly string ToString() => "W:" + cx + " H:" + cy;
    public readonly RECT ToRECT() => new(0, 0, cx, cy);
    public D2D_SIZE_U ToD2D_SIZE_U() => new() { width = (uint)cx, height = (uint)cx };
    public D2D_SIZE_F ToD2D_SIZE_F() => new() { width = (uint)cx, height = (uint)cy };

    public const long HIMETRIC_PER_INCH = 2540;

    [SupportedOSPlatform("windows6.1")]
    public readonly SIZE PixelToHiMetric()
    {
        var dpi = Functions.Dpi;
        return new SIZE((uint)(HIMETRIC_PER_INCH * cx / dpi.width), (uint)(HIMETRIC_PER_INCH * cy / dpi.height));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly SIZE HiMetricToPixel()
    {
        var dpi = Functions.Dpi;
        return new SIZE((uint)(cx * dpi.width / HIMETRIC_PER_INCH), (uint)(cy * dpi.height / HIMETRIC_PER_INCH));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F PixelToHiMetricF()
    {
        var dpi = Functions.Dpi;
        return new D2D_SIZE_F(HIMETRIC_PER_INCH * cx / dpi.width, HIMETRIC_PER_INCH * cy / dpi.height);
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F HiMetricToPixelF()
    {
        var dpi = Functions.Dpi;
        return new D2D_SIZE_F(cx * dpi.width / HIMETRIC_PER_INCH, cy * dpi.height / HIMETRIC_PER_INCH);
    }
}
