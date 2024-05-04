namespace DirectN;

public partial struct RECT
{
    public int Width
    {
        readonly get => Math.Abs(right - left);
        set
        {
            if (value < 0)
                throw new ArgumentException(null, nameof(value));

            right = left + value;
        }
    }

    public int Height
    {
        readonly get => Math.Abs(bottom - top);
        set
        {
            if (value < 0)
                throw new ArgumentException(null, nameof(value));

            bottom = top + value;
        }
    }

    public RECT(int left, int top, int right, int bottom)
    {
        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
    }

    public RECT(int left, int top, SIZE size)
    {
        this.left = left;
        this.top = top;
        right = (int)(left + size.cx);
        bottom = (int)(top + size.cy);
    }

    public RECT(POINT pt, SIZE size)
    {
        left = pt.x;
        top = pt.y;
        right = (int)(left + size.cx);
        bottom = (int)(top + size.cy);
    }

    public RECT(double left, double top, double right, double bottom)
    {
        this.left = left.FloorI();
        this.top = top.FloorI();
        this.right = right.CeilingI();
        this.bottom = bottom.CeilingI();
    }

    public RECT(float left, float top, float right, float bottom)
    {
        this.left = left.FloorI();
        this.top = top.FloorI();
        this.right = right.CeilingI();
        this.bottom = bottom.CeilingI();
    }

    public readonly bool IsEmpty => Width == 0 || Height == 0;
    public override readonly string ToString() => "L:" + left + " T:" + top + " W:" + Width + " H:" + Height + " R:" + right + " B:" + bottom;

    public readonly POINT Position => new(left, top);
    public readonly SIZE Size => new(Width, Height);
    public readonly POINT LeftTop => new(left, top);
    public readonly POINT LeftBottom => new(left, bottom);
    public readonly POINT RightTop => new(right, top);
    public readonly POINT RightBottom => new(right, bottom);
    public readonly RECT Abs => new(Math.Abs(left), Math.Abs(top), Math.Abs(right), Math.Abs(bottom));

    public readonly bool Contains(RECT rect) => left <= rect.left && top <= rect.top && right >= rect.right && bottom >= rect.bottom;
    public readonly bool Contains(int left, int top) => this.left <= left && this.top <= top && right >= left && bottom >= top;
    public readonly bool Contains(POINT point) => Contains(point.x, point.y);
    public readonly bool Equals(RECT other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public override readonly bool Equals(object? obj) => obj is RECT rc && Equals(rc);
    public override readonly int GetHashCode() => left.GetHashCode() ^ top.GetHashCode() ^ right.GetHashCode() ^ bottom.GetHashCode();

    public static bool operator ==(RECT left, RECT right) => left.Equals(right);
    public static bool operator !=(RECT left, RECT right) => !left.Equals(right);

    public static RECT Sized(int left, int top, int width, int height) => new(left, top, left + width, top + height);
    public static RECT Thickness(int horizontal, int vertical) => Thickness(horizontal, vertical, horizontal, vertical);
    public static RECT Thickness(int all) => Thickness(all, all, all, all);
    public static RECT Thickness(int left, int top, int right, int bottom) => new() { left = left, top = top, right = right, bottom = bottom }; // don't change how this is done (avoids validation)

    public readonly D2D_RECT_F ToD2D_RECT_F() => new(left, top, right, bottom);

    [SupportedOSPlatform("windows6.1")]
    public readonly RECT PixelToHiMetric()
    {
        var dpi = Functions.Dpi;
        return new RECT(
            (int)(SIZE.HIMETRIC_PER_INCH * left / dpi.width),
            (int)(SIZE.HIMETRIC_PER_INCH * top / dpi.height),
            (int)(SIZE.HIMETRIC_PER_INCH * right / dpi.width),
            (int)(SIZE.HIMETRIC_PER_INCH * bottom / dpi.height)
            );
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_RECT_F PixelToHiMetricF()
    {
        var dpi = Functions.Dpi;
        return new D2D_RECT_F(
            SIZE.HIMETRIC_PER_INCH * left / dpi.width,
            SIZE.HIMETRIC_PER_INCH * top / dpi.height,
            SIZE.HIMETRIC_PER_INCH * right / dpi.width,
            SIZE.HIMETRIC_PER_INCH * bottom / dpi.height
            );
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly RECT HiMetricToPixel()
    {
        var dpi = Functions.Dpi;
        return new RECT(
            (int)(left * dpi.width / SIZE.HIMETRIC_PER_INCH),
            (int)(top * dpi.height / SIZE.HIMETRIC_PER_INCH),
            (int)(right * dpi.width / SIZE.HIMETRIC_PER_INCH),
            (int)(bottom * dpi.height / SIZE.HIMETRIC_PER_INCH));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_RECT_F HiMetricToPixelF()
    {
        var dpi = Functions.Dpi;
        return new D2D_RECT_F(
            left * dpi.width / SIZE.HIMETRIC_PER_INCH,
            top * dpi.height / SIZE.HIMETRIC_PER_INCH,
            right * dpi.width / SIZE.HIMETRIC_PER_INCH,
            bottom * dpi.height / SIZE.HIMETRIC_PER_INCH);
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly RECT PixelToDip()
    {
        var scale = Functions.DpiScale;
        if (scale.width == 1 && scale.height == 1)
            return this;

        return new RECT((int)(left / scale.width), (int)(top / scale.height), (int)(right / scale.width), (int)(bottom / scale.height));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly RECT DipToPixel()
    {
        var scale = Functions.DpiScale;
        if (scale.width == 1 && scale.height == 1)
            return this;

        return new RECT((int)(left * scale.width), (int)(top * scale.height), (int)(right * scale.width), (int)(bottom * scale.height));
    }
}
