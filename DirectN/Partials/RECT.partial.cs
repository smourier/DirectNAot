namespace DirectN;

public partial struct RECT : IEquatable<RECT>, IEquatable<D2D_RECT_U>, IEquatable<D2D_RECT_F>
{
    public static RECT Zero => default;

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
        right = left + size.cx;
        bottom = top + size.cy;
    }

    public RECT(POINT pt, SIZE size)
    {
        left = pt.x;
        top = pt.y;
        right = left + size.cx;
        bottom = top + size.cy;
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
    public override readonly string ToString() => $"{left},{top},{right},{bottom}";

    public readonly POINT Position => new(left, top);
    public readonly SIZE Size => new(Width, Height);
    public readonly POINT LeftTop => new(left, top);
    public readonly POINT LeftBottom => new(left, bottom);
    public readonly POINT RightTop => new(right, top);
    public readonly POINT RightBottom => new(right, bottom);
    public readonly RECT Abs => new(Math.Abs(left), Math.Abs(top), Math.Abs(right), Math.Abs(bottom));

    public readonly IEnumerable<POINT> Points
    {
        get
        {
            yield return LeftTop;
            yield return RightTop;
            yield return RightBottom;
            yield return LeftBottom;
        }
    }

    public readonly bool Contains(RECT rect) => left <= rect.left && top <= rect.top && right >= rect.right && bottom >= rect.bottom;
    public readonly bool Contains(int left, int top) => this.left <= left && this.top <= top && right >= left && bottom >= top;
    public readonly bool Contains(POINT point) => Contains(point.x, point.y);

    public override readonly bool Equals(object? obj) =>
        (obj is RECT rc && Equals(rc)) ||
        (obj is D2D_RECT_F rf && Equals(rf)) ||
        (obj is D2D_RECT_U ru && Equals(ru));
    public readonly bool Equals(RECT other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public override readonly int GetHashCode() => left.GetHashCode() ^ top.GetHashCode() ^ right.GetHashCode() ^ bottom.GetHashCode();
    public static bool operator ==(RECT left, RECT right) => left.Equals(right);
    public static bool operator !=(RECT left, RECT right) => !left.Equals(right);

    public static implicit operator RECT(D2D_RECT_F rc) => new(rc.left, rc.top, rc.right, rc.bottom);
    public static implicit operator RECT(D2D_RECT_U rc) => new(rc.left, rc.top, rc.right, rc.bottom);

    public readonly bool Equals(D2D_RECT_F other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public readonly bool Equals(D2D_RECT_U other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;

    public static RECT Sized(int left, int top, int width, int height) => new(left, top, left + width, top + height);
    public static RECT Thickness(int horizontal, int vertical) => Thickness(horizontal, vertical, horizontal, vertical);
    public static RECT Thickness(int all) => Thickness(all, all, all, all);
    public static RECT Thickness(int left, int top, int right, int bottom) => new() { left = left, top = top, right = right, bottom = bottom }; // don't change how this is done (avoids validation)

    public readonly D2D_RECT_F ToD2D_RECT_F() => new(left, top, right, bottom);

    public readonly RECT PixelToHiMetric()
    {
        var dpi = Functions.Dpi;
        return new RECT(
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi.width),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi.height),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi.width),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi.height)
            );
    }

    public readonly D2D_RECT_F PixelToHiMetricF()
    {
        var dpi = Functions.Dpi;
        return new D2D_RECT_F(
            D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi.width,
            D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi.height,
            D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi.width,
            D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi.height
            );
    }

    public readonly RECT HiMetricToPixel()
    {
        var dpi = Functions.Dpi;
        return new RECT(
            (int)(left * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(top * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(right * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(bottom * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH));
    }

    public readonly D2D_RECT_F HiMetricToPixelF()
    {
        var dpi = Functions.Dpi;
        return new D2D_RECT_F(
            left * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH,
            top * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH,
            right * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH,
            bottom * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH);
    }

    public readonly RECT PixelToDip()
    {
        var scale = Functions.DpiScale;
        if (scale.width == 1 && scale.height == 1)
            return this;

        return new RECT((int)(left / scale.width), (int)(top / scale.height), (int)(right / scale.width), (int)(bottom / scale.height));
    }

    public readonly RECT DipToPixel()
    {
        var scale = Functions.DpiScale;
        if (scale.width == 1 && scale.height == 1)
            return this;

        return new RECT((int)(left * scale.width), (int)(top * scale.height), (int)(right * scale.width), (int)(bottom * scale.height));
    }
}
