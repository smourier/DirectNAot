namespace DirectN;

public partial struct D2D_RECT_F : IEquatable<RECT>, IEquatable<D2D_RECT_U>, IEquatable<D2D_RECT_F>
{
    public static D2D_RECT_F Zero => default;

    public D2D_RECT_F(float left, float top, float right, float bottom)
    {
#if DEBUG
        if (left.IsNotSet())
            throw new ArgumentException(null, nameof(left));

        if (top.IsNotSet())
            throw new ArgumentException(null, nameof(top));

        if (right.IsNotSet())
            throw new ArgumentException(null, nameof(right));

        if (bottom.IsNotSet())
            throw new ArgumentException(null, nameof(bottom));

        if (right < left)
            throw new ArgumentException(null, nameof(right));

        if (bottom < top)
            throw new ArgumentException(null, nameof(bottom));
#endif

        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
    }

    public D2D_RECT_F(double left, double top, double right, double bottom)
        : this((float)left, (float)top, (float)right, (float)bottom)
    {
    }

    public D2D_RECT_F(D2D_POINT_2F location, float width, float height)
        : this(location, new D2D_SIZE_F(width, height))
    {
    }

    public D2D_RECT_F(D2D_POINT_2F leftTop, D2D_POINT_2F rightBottom)
        : this(leftTop.x, leftTop.y, rightBottom.x, rightBottom.y)
    {
    }

    public D2D_RECT_F(D2D_POINT_2F location, D2D_SIZE_F size)
    {
        left = location.x;
        top = location.y;
        right = left + size.width;
        bottom = top + size.height;
    }

    public D2D_RECT_F(D2D_SIZE_F size)
    {
        left = 0;
        top = 0;
        right = size.width;
        bottom = size.height;
    }

    public D2D_RECT_F(RECT rc)
    {
        left = rc.left;
        top = rc.top;
        right = left + rc.Width;
        bottom = top + rc.Height;
    }

    public D2D_RECT_F(float left, float top, D2D_SIZE_F size)
    {
#if DEBUG
        if (left.IsNotSet())
            throw new ArgumentException(null, nameof(left));

        if (top.IsNotSet())
            throw new ArgumentException(null, nameof(top));
#endif

        this.left = left;
        this.top = top;
        right = left + size.width;
        bottom = top + size.height;
    }

    public readonly float HorizontalThickness => right + left;
    public readonly float VerticalThickness => top + bottom;

    public float Width
    {
        readonly get => Math.Abs(right - left);
        set
        {
            if (float.IsNaN(value) || value < 0)
                throw new ArgumentException(null, nameof(value));

            right = left + value;
        }
    }

    public float Height
    {
        readonly get => Math.Abs(bottom - top);
        set
        {
            if (float.IsNaN(value) || value < 0)
                throw new ArgumentException(null, nameof(value));

            bottom = top + value;
        }
    }

    public readonly D2D_POINT_2F CenterPoint => new(left + Width / 2f, top + Height / 2f);

    public D2D_SIZE_F Size { readonly get => new(Width, Height); set { Width = value.width; Height = value.height; } }
    public readonly D2D_SIZE_U SizeU => new() { width = (uint)Width, height = (uint)Height };
    public readonly D2D_SIZE_U SizeCeilingU => new() { width = Width.CeilingU(), height = Height.CeilingU() };
    public readonly D2D_POINT_2F LeftTop => new(left, top);
    public readonly D2D_POINT_2F LeftBottom => new(left, bottom);
    public readonly D2D_POINT_2F RightTop => new(right, top);
    public readonly D2D_POINT_2F RightBottom => new(right, bottom);

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => double.IsNaN(left) || double.IsNaN(top) || double.IsNaN(right) || double.IsNaN(bottom);
    public readonly bool IsSizeZero => Width == 0 && Height == 0;
    public readonly bool IsEmpty => Width == 0 || Height == 0;
    public readonly bool IsZero => left == 0 && top == 0 && right == 0 && bottom == 0;
    public readonly bool IsSet => left.IsSet() && top.IsSet() && Width.IsSet() && Height.IsSet();
    public readonly bool IsNotSet => !IsSet;

    public readonly RECT ToRECT() => new(left, top, right, bottom);
    public readonly D2D_RECT_U ToD2D_RECT_U() => new(left, top, right, bottom);
    public readonly D2D_RECT_F ToFloorCeiling() => new(left.Floor(), top.Floor(), right.Ceiling(), bottom.Ceiling());
    public readonly D2D_RECT_F Translate(float left, float top) => Sized(this.left + left, this.top + top, Width, Height);
    public readonly D2D_RECT_F Resize(float width, float height) => Sized(left, top, width, height);
    public readonly D2D_RECT_F Center(D2D_RECT_F parent) => new(parent.left + (parent.Width - Width) / 2f, parent.top + (parent.Height - Height) / 2f, Size);
    public readonly D2D_RECT_F CenterHorizontally(D2D_RECT_F parent) => new(parent.left + (parent.Width - Width) / 2f, top, Size);
    public readonly D2D_RECT_F CenterVertically(D2D_RECT_F parent) => new(left, parent.top + (parent.Height - Height) / 2f, Size);

    public void Move(D2D_VECTOR_2F vector) => Move(vector.x, vector.y);
    public void Move(float x, float y)
    {
        left += x;
        top += y;
        right += x;
        bottom += y;
    }

    public static D2D_RECT_F Sized(float left, float top, float width, float height) => new(left, top, left + width, top + height);
    public static D2D_RECT_F Thickness(float horizontal, float vertical) => Thickness(horizontal, vertical, horizontal, vertical);
    public static D2D_RECT_F Thickness(float all) => Thickness(all, all, all, all);
    public static D2D_RECT_F Thickness(float left, float top, float right, float bottom) => new() { left = left, top = top, right = right, bottom = bottom }; // don't change how this is done (avoids validation)

    public readonly D2D_RECT_F Deflate(float thickness) => Sized(left + thickness, top + thickness, Math.Max(0, Width - 2 * thickness), Math.Max(0, Height - 2 * thickness));
    public readonly D2D_RECT_F Inflate(float thickness) => Deflate(-thickness);
    public readonly D2D_RECT_F Deflate(float left, float top, float right, float bottom) => Sized(this.left + left, this.top + top, Math.Max(0, Width - 2 * right), Math.Max(0, Height - 2 * bottom));
    public readonly D2D_RECT_F Inflate(float left, float top, float right, float bottom) => Deflate(-left, -top, -right, -bottom);
    public readonly D2D_RECT_F Deflate(D2D_RECT_F rect) => Sized(left + rect.left, top + rect.top, Math.Max(0, Width - 2 * rect.right), Math.Max(0, Height - 2 * rect.bottom));
    public readonly D2D_RECT_F Inflate(D2D_RECT_F rect) => Sized(left - rect.left, top - rect.top, Math.Max(0, Width - 2 * -rect.right), Math.Max(0, Height - 2 * -rect.bottom));

    public readonly D2D_RECT_F Intersect(D2D_RECT_F rect)
    {
        var l = Math.Max(left, rect.left);
        var t = Math.Max(top, rect.top);
        return new D2D_RECT_F(l, t, Math.Max(l, Math.Min(right, rect.right)), Math.Max(t, Math.Min(bottom, rect.bottom)));
    }

    public readonly bool IntersectsWith(D2D_RECT_F rect)
    {
        var i = Intersect(rect);
        return i.Width > 0 && i.Height > 0;
    }

    public readonly bool Contains(D2D_RECT_F rect) => left <= rect.left && top <= rect.top && right >= rect.right && bottom >= rect.bottom;
    public readonly bool Contains(float left, float top) => this.left <= left && this.top <= top && right >= left && bottom >= top;
    public readonly bool Contains(D2D_POINT_2F point) => Contains(point.x, point.y);
    public readonly D2D_RECT_F Union(D2D_RECT_F rect)
    {
        var left = Math.Min(this.left, rect.left);
        var top = Math.Min(this.top, rect.top);
        var right = Math.Max(this.right, rect.right);
        var bottom = Math.Max(this.bottom, rect.bottom);
        return Sized(left, top, Math.Max(0, right - left), Math.Max(0, bottom - top));
    }

    public readonly D2D_RECT_F FitIn(D2D_RECT_F rect, bool shrinkOnly)
    {
        if (IsEmpty)
            return this;

        if (shrinkOnly && Width <= rect.Width && Height <= rect.Height)
            return new D2D_RECT_F(rect.left, rect.top, Width, Height);

        float w;
        float h;
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
        return new D2D_RECT_F(l, t, w + l, h + t);
    }

    public readonly D2D_RECT_F MoveInside(D2D_RECT_F outer)
    {
        var newLeft = left;
        var newTop = top;

        if (left < outer.left)
        {
            newLeft = outer.left;
        }
        else if (right > outer.right)
        {
            newLeft = outer.right - Width;
        }

        if (top < outer.top)
        {
            newTop = outer.top;
        }
        else if (bottom > outer.bottom)
        {
            newTop = outer.bottom - Height;
        }

        return new D2D_RECT_F
        {
            left = newLeft,
            top = newTop,
            Width = Width,
            Height = Height
        };
    }

    public readonly D2D_RECT_F TransformToBounds(ref Matrix4x4 matrix)
    {
        var xMin = left;
        var xMax = right;
        var yMin = top;
        var yMax = bottom;

        transformPoint(ref matrix, left, top);
        transformPoint(ref matrix, right, top);
        transformPoint(ref matrix, left, bottom);
        transformPoint(ref matrix, right, bottom);
        return new D2D_RECT_F(xMin, yMin, xMax, yMax);

        void transformPoint(ref Matrix4x4 m, float x, float y)
        {
            var px = x * m.M11 + y * m.M21 + m.M31;
            var py = x * m.M12 + y * m.M22 + m.M32;
            if (px > xMax)
            {
                xMax = px;
            }
            else if (px < xMin)
            {
                xMin = px;
            }

            if (py > yMax)
            {
                yMax = py;
            }
            else if (py < yMin)
            {
                yMin = py;
            }
        }
    }

    public readonly IEnumerable<D2D_POINT_2F> Points
    {
        get
        {
            yield return LeftTop;
            yield return RightTop;
            yield return RightBottom;
            yield return LeftBottom;
        }
    }

    public static D2D_RECT_F? Union(IEnumerable<D2D_POINT_2F> points)
    {
        ArgumentNullException.ThrowIfNull(points);
        D2D_RECT_F? rc = null;
        foreach (var pt in points)
        {
            if (pt.IsInvalid)
                continue;

            if (rc == null)
            {
                rc = new D2D_RECT_F(pt.x, pt.y, pt.x, pt.y);
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

    public static D2D_RECT_F? Union(IEnumerable<D2D_RECT_F> rects)
    {
        ArgumentNullException.ThrowIfNull(rects);
        D2D_RECT_F? rc = null;
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

    public override readonly string ToString() => $"{left},{top},{right},{bottom}";

    public override readonly bool Equals(object? obj) =>
        (obj is RECT rc && Equals(rc)) ||
        (obj is D2D_RECT_F rf && Equals(rf)) ||
        (obj is D2D_RECT_U ru && Equals(ru));
    public readonly bool Equals(D2D_RECT_F other) => IsInvalid && other.IsInvalid || (left == other.left && top == other.top && right == other.right && bottom == other.bottom);
    public override readonly int GetHashCode() => left.GetHashCode() ^ top.GetHashCode() ^ right.GetHashCode() ^ bottom.GetHashCode();
    public static bool operator ==(D2D_RECT_F left, D2D_RECT_F right) => left.Equals(right);
    public static bool operator !=(D2D_RECT_F left, D2D_RECT_F right) => !(left == right);

    public readonly bool Equals(RECT other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;
    public readonly bool Equals(D2D_RECT_U other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;

    public static implicit operator D2D_RECT_F(float all) => Thickness(all);
    public static implicit operator D2D_RECT_F(D2D_RECT_U rc) => new(rc.left, rc.top, rc.right, rc.bottom);
    public static implicit operator D2D_RECT_F(RECT rc) => new(rc.left, rc.top, rc.right, rc.bottom);

    // margin/thickness type calculation
    public static D2D_RECT_F operator +(D2D_RECT_F left, D2D_RECT_F right)
    {
        if (left.IsInvalid || right.IsInvalid)
            return Invalid;

        return Sized(left.left - right.left, left.top - right.top, left.Width + right.HorizontalThickness, left.Height + right.VerticalThickness);
    }

    // margin/thickness type calculation
    public static D2D_RECT_F operator -(D2D_RECT_F left, D2D_RECT_F right)
    {
        if (left.IsInvalid || right.IsInvalid)
            return Invalid;

        return Sized(left.left + right.left, left.top + right.top, Math.Max(0, left.Width - right.HorizontalThickness), Math.Max(0, left.Height - right.VerticalThickness));
    }

    // margin/thickness type calculation
    public static D2D_SIZE_F operator +(D2D_SIZE_F left, D2D_RECT_F right) => new(left.width + right.HorizontalThickness, left.height + right.VerticalThickness);
    public static D2D_SIZE_F operator -(D2D_SIZE_F left, D2D_RECT_F right) => new(Math.Max(0, left.width - right.HorizontalThickness), Math.Max(0, left.height - right.VerticalThickness));

#if DEBUG
    public static readonly D2D_RECT_F Invalid = new() { left = float.NaN, top = float.NaN, right = float.NaN, bottom = float.NaN };
#else
    public static readonly D2D_RECT_F Invalid = new(float.NaN, float.NaN, float.NaN, float.NaN);
#endif
}
