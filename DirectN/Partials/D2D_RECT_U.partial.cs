namespace DirectN;

public partial struct D2D_RECT_U : IEquatable<RECT>, IEquatable<D2D_RECT_U>, IEquatable<D2D_RECT_F>, IParsable<D2D_RECT_U>
{
    public static D2D_RECT_U Zero => default;

    public D2D_RECT_U(uint left, uint top, uint right, uint bottom)
    {
        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
    }

    public D2D_RECT_U(float left, float top, float right, float bottom)
    {
        this.left = (uint)left;
        this.top = (uint)top;
        this.right = (uint)right;
        this.bottom = (uint)bottom;
    }

    public D2D_RECT_U(double left, double top, double right, double bottom)
    {
        this.left = (uint)left;
        this.top = (uint)top;
        this.right = (uint)right;
        this.bottom = (uint)bottom;
    }

    public D2D_RECT_U(D2D_POINT_2U location, uint width, uint height)
        : this(location, new D2D_SIZE_U(width, height))
    {
    }

    public D2D_RECT_U(D2D_POINT_2U leftTop, D2D_POINT_2U rightBottom)
        : this(leftTop.x, leftTop.y, rightBottom.x, rightBottom.y)
    {
    }

    public D2D_RECT_U(D2D_POINT_2U location, D2D_SIZE_U size)
    {
        left = location.x;
        top = location.y;
        right = left + size.width;
        bottom = top + size.height;
    }

    public D2D_RECT_U(D2D_SIZE_U size)
    {
        left = 0;
        top = 0;
        right = size.width;
        bottom = size.height;
    }

    public D2D_RECT_U(RECT rc)
    {
        left = (uint)rc.left;
        top = (uint)rc.top;
        right = (uint)(left + rc.Width);
        bottom = (uint)(top + rc.Height);
    }

    public readonly uint HorizontalThickness => right + left;
    public readonly uint VerticalThickness => top + bottom;

    public uint Width { readonly get => right >= left ? right - left : left - right; set { right = left + value; } }
    public uint Height { readonly get => bottom >= top ? bottom - top : top - bottom; set { bottom = top + value; } }

    public readonly bool IsEmpty => Width == 0 || Height == 0;
    public readonly bool IsZero => left == 0 && top == 0 && right == 0 && bottom == 0;

    public readonly D2D_POINT_2U CenterPoint => new(left + Width / 2, top + Height / 2);

    public D2D_SIZE_U Size { readonly get => new(Width, Height); set { Width = value.width; Height = value.height; } }
    public readonly D2D_SIZE_F SizeU => new(Width, Height);
    public readonly D2D_POINT_2U LeftTop => new(left, top);
    public readonly D2D_POINT_2U LeftBottom => new(left, bottom);
    public readonly D2D_POINT_2U RightTop => new(right, top);
    public readonly D2D_POINT_2U RightBottom => new(right, bottom);

    public readonly RECT ToRECT() => new(left, top, right, bottom);
    public readonly D2D_RECT_F ToD2D_RECT_F() => new(left, top, right, bottom);

    public void Move(uint x, uint y)
    {
        left += x;
        top += y;
        right += x;
        bottom += y;
    }

    public static D2D_RECT_U Sized(uint left, uint top, uint width, uint height) => new(left, top, left + width, top + height);
    public static D2D_RECT_U Thickness(uint horizontal, uint vertical) => Thickness(horizontal, vertical, horizontal, vertical);
    public static D2D_RECT_U Thickness(uint all) => Thickness(all, all, all, all);
    public static D2D_RECT_U Thickness(uint left, uint top, uint right, uint bottom) => new(left, top, right, bottom);

    public readonly D2D_RECT_U Deflate(int thickness) => Sized((uint)Math.Max(0, left + thickness), (uint)Math.Max(0, top + thickness), (uint)Math.Max(0, Width - 2 * thickness), (uint)Math.Max(0, Height - 2 * thickness));
    public readonly D2D_RECT_U Inflate(int thickness) => Deflate(-thickness);
    public readonly D2D_RECT_U Deflate(int left, int top, int right, int bottom) => Sized((uint)Math.Max(0, this.left + left), (uint)Math.Max(0, this.top + top), (uint)Math.Max(0, Width - 2 * right), (uint)Math.Max(0, Height - 2 * bottom));
    public readonly D2D_RECT_U Inflate(int left, int top, int right, int bottom) => Deflate(-left, -top, -right, -bottom);
    public readonly D2D_RECT_U Deflate(D2D_RECT_U rect) => Sized(left + rect.left, top + rect.top, Math.Max(0, Width - 2 * rect.right), Math.Max(0, Height - 2 * rect.bottom));
    public readonly D2D_RECT_U Inflate(D2D_RECT_U rect) => Sized((uint)Math.Max(0, (int)left - (int)rect.left), (uint)Math.Max(0, (int)top - (int)rect.top), (uint)Math.Max(0, (int)Width - 2 * -(int)rect.right), (uint)Math.Max(0, (int)Height - 2 * -(int)rect.bottom));

    public readonly D2D_RECT_U Intersect(D2D_RECT_U rect)
    {
        var l = Math.Max(left, rect.left);
        var t = Math.Max(top, rect.top);
        return new D2D_RECT_U(l, t, Math.Max(l, Math.Min(right, rect.right)), Math.Max(t, Math.Min(bottom, rect.bottom)));
    }

    public readonly bool IntersectsWith(D2D_RECT_U rect)
    {
        var i = Intersect(rect);
        return i.Width > 0 && i.Height > 0;
    }

    public readonly bool Contains(D2D_RECT_U rect) => left <= rect.left && top <= rect.top && right >= rect.right && bottom >= rect.bottom;
    public readonly bool Contains(uint left, uint top) => this.left <= left && this.top <= top && right >= left && bottom >= top;
    public readonly D2D_RECT_U Union(D2D_RECT_U rect)
    {
        var left = Math.Min(this.left, rect.left);
        var top = Math.Min(this.top, rect.top);
        var right = Math.Max(this.right, rect.right);
        var bottom = Math.Max(this.bottom, rect.bottom);
        return Sized(left, top, Math.Max(0, right - left), Math.Max(0, bottom - top));
    }

    public readonly D2D_RECT_U FitIn(D2D_RECT_U rect, bool shrinkOnly)
    {
        if (IsEmpty)
            return this;

        if (shrinkOnly && Width <= rect.Width && Height <= rect.Height)
            return new D2D_RECT_U(rect.left, rect.top, Width, Height);

        uint w;
        uint h;
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

        var l = rect.left + (rect.Width - w) / 2;
        var t = rect.top + (rect.Height - h) / 2;
        return new D2D_RECT_U(l, t, w + l, h + t);
    }

    public readonly D2D_RECT_U TransformToBounds(ref Matrix4x4 matrix)
    {
        var xMin = left;
        var xMax = right;
        var yMin = top;
        var yMax = bottom;

        transformPoint(ref matrix, left, top);
        transformPoint(ref matrix, right, top);
        transformPoint(ref matrix, left, bottom);
        transformPoint(ref matrix, right, bottom);
        return new D2D_RECT_U(xMin, yMin, xMax, yMax);

        void transformPoint(ref Matrix4x4 m, uint x, uint y)
        {
            var px = x * m.M11 + y * m.M21 + m.M31;
            var py = x * m.M12 + y * m.M22 + m.M32;
            if (px > xMax)
            {
                xMax = (uint)px;
            }
            else if (px < xMin)
            {
                xMin = (uint)px;
            }

            if (py > yMax)
            {
                yMax = (uint)py;
            }
            else if (py < yMin)
            {
                yMin = (uint)py;
            }
        }
    }

    public readonly IEnumerable<D2D_POINT_2U> Points
    {
        get
        {
            yield return LeftTop;
            yield return RightTop;
            yield return RightBottom;
            yield return LeftBottom;
        }
    }

    public static D2D_RECT_U Union(IEnumerable<D2D_POINT_2U> points)
    {
        ArgumentNullException.ThrowIfNull(points);
        uint? left = null;
        uint? top = null;
        uint? right = null;
        uint? bottom = null;
        foreach (var pt in points)
        {
            if (left == null)
            {
                left = pt.x;
                top = pt.y;
                right = pt.x;
                bottom = pt.y;
            }

            if (pt.x < left.Value)
            {
                left = pt.x;
            }
            else if (pt.x > right!.Value)
            {
                right = pt.x;
            }

            if (pt.y < top!.Value)
            {
                top = pt.y;
            }
            else if (pt.y > bottom!.Value)
            {
                bottom = pt.y;
            }
        }

        if (left == null)
            throw new ArgumentException(null, nameof(points));

        return new D2D_RECT_U(left.Value, top!.Value, right!.Value, bottom!.Value);
    }

    public static D2D_RECT_U Union(IEnumerable<D2D_RECT_U> rects)
    {
        var rc = new D2D_RECT_U();
        if (rects != null)
        {
            foreach (var rect in rects)
            {
                rc = rc.Union(rect);
            }
        }
        return rc;
    }

    public override readonly string ToString() => $"{left};{top};{right};{bottom}";

    public override readonly bool Equals(object? obj) =>
        (obj is RECT rc && Equals(rc)) ||
        (obj is D2D_RECT_F rf && Equals(rf)) ||
        (obj is D2D_RECT_U ru && Equals(ru));
    public readonly bool Equals(D2D_RECT_U other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public override readonly int GetHashCode() => left.GetHashCode() ^ top.GetHashCode() ^ right.GetHashCode() ^ bottom.GetHashCode();
    public static bool operator ==(D2D_RECT_U left, D2D_RECT_U right) => left.Equals(right);
    public static bool operator !=(D2D_RECT_U left, D2D_RECT_U right) => !(left == right);

    public readonly bool Equals(RECT other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public readonly bool Equals(D2D_RECT_F other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;

    public static implicit operator D2D_RECT_U(uint all) => Thickness(all);
    public static implicit operator D2D_RECT_U(D2D_RECT_F rc) => new(rc.left, rc.top, rc.right, rc.bottom);
    public static implicit operator D2D_RECT_U(RECT rc) => new(rc.left, rc.top, rc.right, rc.bottom);

    // margin/thickness type calculation
    public static D2D_RECT_U operator +(D2D_RECT_U left, D2D_RECT_U right) => Sized((uint)Math.Max(0, (int)left.left - (int)right.left), (uint)Math.Max(0, (int)left.top - (int)right.top), (uint)Math.Max(0, (int)left.Width + (int)right.HorizontalThickness), (uint)Math.Max(0, (int)left.Height + (int)right.VerticalThickness));

    // margin/thickness type calculation
    public static D2D_RECT_U operator -(D2D_RECT_U left, D2D_RECT_U right) => Sized(left.left + right.left, left.top + right.top, (uint)Math.Max(0, (int)left.Width - (int)right.HorizontalThickness), (uint)Math.Max(0, (int)left.Height - (int)right.VerticalThickness));

    // margin/thickness type calculation
    public static D2D_SIZE_U operator +(D2D_SIZE_U left, D2D_RECT_U right) => new(left.width + right.HorizontalThickness, left.height + right.VerticalThickness);
    public static D2D_SIZE_U operator -(D2D_SIZE_F left, D2D_RECT_U right) => new((uint)Math.Max(0, (int)left.width - (int)right.HorizontalThickness), (uint)Math.Max(0, (int)left.height - (int)right.VerticalThickness));

    public static D2D_RECT_U Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 4)
            throw new FormatException();

        var left = uint.Parse(parts[0], provider);
        var top = uint.Parse(parts[1], provider);
        var right = uint.Parse(parts[2], provider);
        var bottom = uint.Parse(parts[3], provider);
        return new D2D_RECT_U(left, top, right, bottom);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out D2D_RECT_U result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 4)
            return false;

        if (!uint.TryParse(parts[0], provider, out var left) ||
            !uint.TryParse(parts[1], provider, out var top) ||
            !uint.TryParse(parts[2], provider, out var right) ||
            !uint.TryParse(parts[3], provider, out var bottom))
            return false;

        result = new D2D_RECT_U(left, top, right, bottom);
        return true;
    }
}
