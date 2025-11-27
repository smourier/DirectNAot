namespace DirectN;

public partial struct RECT : IEquatable<RECT>, IEquatable<D2D_RECT_U>, IEquatable<D2D_RECT_F>, IParsable<RECT>
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
    public override readonly string ToString() => $"{left};{top};{right};{bottom}";

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

    public readonly RECT Deflate(int thickness) => Sized(left + thickness, top + thickness, Math.Max(0, Width - 2 * thickness), Math.Max(0, Height - 2 * thickness));
    public readonly RECT Inflate(int thickness) => Deflate(-thickness);
    public readonly RECT Deflate(int left, int top, int right, int bottom) => Sized(this.left + left, this.top + top, Math.Max(0, Width - 2 * right), Math.Max(0, Height - 2 * bottom));
    public readonly RECT Inflate(int left, int top, int right, int bottom) => Deflate(-left, -top, -right, -bottom);
    public readonly RECT Deflate(RECT rect) => Sized(left + rect.left, top + rect.top, Math.Max(0, Width - 2 * rect.right), Math.Max(0, Height - 2 * rect.bottom));
    public readonly RECT Inflate(RECT rect) => Sized(left - rect.left, top - rect.top, Math.Max(0, Width - 2 * -rect.right), Math.Max(0, Height - 2 * -rect.bottom));

    public readonly RECT Intersect(RECT rect)
    {
        var l = Math.Max(left, rect.left);
        var t = Math.Max(top, rect.top);
        return new RECT(l, t, Math.Max(l, Math.Min(right, rect.right)), Math.Max(t, Math.Min(bottom, rect.bottom)));
    }

    public readonly bool IntersectsWith(RECT rect)
    {
        var i = Intersect(rect);
        return i.Width > 0 && i.Height > 0;
    }

    public readonly RECT Union(RECT rect)
    {
        var left = Math.Min(this.left, rect.left);
        var top = Math.Min(this.top, rect.top);
        var right = Math.Max(this.right, rect.right);
        var bottom = Math.Max(this.bottom, rect.bottom);
        return Sized(left, top, Math.Max(0, right - left), Math.Max(0, bottom - top));
    }

    public static RECT? Union(IEnumerable<POINT> points)
    {
        ArgumentNullException.ThrowIfNull(points);
        RECT? rc = null;
        foreach (var pt in points)
        {
            if (rc == null)
            {
                rc = new RECT(pt.x, pt.y, pt.x, pt.y);
                continue;
            }

            var rcv = rc.Value;

            if (pt.x < rcv.left)
            {
                rcv.left = pt.x;
            }
            else if (pt.x > rcv.right)
            {
                rcv.right = pt.x;
            }

            if (pt.y < rcv.top)
            {
                rcv.top = pt.y;
            }
            else if (pt.y > rcv.bottom)
            {
                rcv.bottom = pt.y;
            }

            rc = rcv;
        }
        return rc;
    }

    public static RECT? Union(IEnumerable<RECT> rects)
    {
        ArgumentNullException.ThrowIfNull(rects);
        RECT? rc = null;
        foreach (var rect in rects)
        {
            if (rc == null)
            {
                rc = rect;
            }
            else
            {
                rc = rc.Value.Union(rect);
            }
        }
        return rc;
    }

    public readonly RECT FitIn(RECT rect, bool shrinkOnly)
    {
        if (IsEmpty)
            return this;

        if (shrinkOnly && Width <= rect.Width && Height <= rect.Height)
            return new RECT(rect.left, rect.top, Width, Height);

        int w;
        int h;
        if (Width / Height >= rect.Width / rect.Height)
        {
            w = Width * rect.Width / Width;
            h = Height * rect.Width / Width;
        }
        else
        {
            w = Width * rect.Height / Height;
            h = Height * rect.Height / Height;
        }

        var l = rect.left + (rect.Width - w) / 2f;
        var t = rect.top + (rect.Height - h) / 2f;
        return new RECT(l, t, w + l, h + t);
    }

    public readonly RECT MoveInside(RECT outer, bool shrink = true)
    {
        var newLeft = left;
        var newTop = top;
        var innerWidth = shrink ? Math.Min(outer.Width, Width) : Width;
        var innerHeight = shrink ? Math.Min(outer.Height, Height) : Width;

        if (left < outer.left)
        {
            newLeft = outer.left;
        }
        else if (right > outer.right)
        {
            newLeft = outer.right - innerWidth;
        }

        if (top < outer.top)
        {
            newTop = outer.top;
        }
        else if (bottom > outer.bottom)
        {
            newTop = outer.bottom - innerHeight;
        }

        return Sized(newLeft, newTop, innerWidth, innerHeight);
    }

    public readonly D2D_RECT_F ToD2D_RECT_F() => new(left, top, right, bottom);

    public readonly RECT PixelToHiMetric() => PixelToHiMetric(Functions.Dpi);
    public readonly RECT PixelToHiMetric(D2D_SIZE_F dpi) => new(
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi.width),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi.height),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi.width),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi.height)
            );

    public readonly RECT PixelToHiMetric(uint dpi) => new(
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi),
            (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi)
            );

    public readonly D2D_RECT_F PixelToHiMetricF() => PixelToHiMetricF(Functions.Dpi);
    public readonly D2D_RECT_F PixelToHiMetricF(D2D_SIZE_F dpi) => new(
            D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi.width,
            D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi.height,
            D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi.width,
            D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi.height
            );

    public readonly D2D_RECT_F PixelToHiMetricF(uint dpi) => new(
            D2D_SIZE_F.HIMETRIC_PER_INCH * left / dpi,
            D2D_SIZE_F.HIMETRIC_PER_INCH * top / dpi,
            D2D_SIZE_F.HIMETRIC_PER_INCH * right / dpi,
            D2D_SIZE_F.HIMETRIC_PER_INCH * bottom / dpi
            );

    public readonly RECT HiMetricToPixel() => HiMetricToPixel(Functions.Dpi);
    public readonly RECT HiMetricToPixel(D2D_SIZE_F dpi) => new(
            (int)(left * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(top * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(right * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(bottom * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH));

    public readonly RECT HiMetricToPixel(uint dpi) => new(
            (int)(left * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(top * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(right * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH),
            (int)(bottom * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH));

    public readonly D2D_RECT_F HiMetricToPixelF() => HiMetricToPixelF(Functions.Dpi);
    public readonly D2D_RECT_F HiMetricToPixelF(D2D_SIZE_F dpi) => new(
            left * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH,
            top * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH,
            right * dpi.width / D2D_SIZE_F.HIMETRIC_PER_INCH,
            bottom * dpi.height / D2D_SIZE_F.HIMETRIC_PER_INCH);

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

    public static RECT Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 4)
            throw new FormatException();

        var left = int.Parse(parts[0], provider);
        var top = int.Parse(parts[1], provider);
        var right = int.Parse(parts[2], provider);
        var bottom = int.Parse(parts[3], provider);
        return new RECT(left, top, right, bottom);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out RECT result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 4)
            return false;

        if (!int.TryParse(parts[0], provider, out var left) ||
            !int.TryParse(parts[1], provider, out var top) ||
            !int.TryParse(parts[2], provider, out var right) ||
            !int.TryParse(parts[3], provider, out var bottom))
            return false;

        result = new RECT(left, top, right, bottom);
        return true;
    }
}
