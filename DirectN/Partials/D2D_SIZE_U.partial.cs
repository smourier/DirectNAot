namespace DirectN;

public partial struct D2D_SIZE_U : IEquatable<D2D_SIZE_U>, IEquatable<D2D_SIZE_F>, IEquatable<SIZE>, IEquatable<Vector2>, IEquatable<D2D_VECTOR_2F>
{
    public static D2D_SIZE_U Zero => default;

    public D2D_SIZE_U(uint width, uint height)
    {
        this.width = width;
        this.height = height;
    }

    public D2D_SIZE_U(int width, int height)
    {
        this.width = (uint)width;
        this.height = (uint)height;
    }

    public D2D_SIZE_U(float width, float height)
    {
        this.width = width.FloorU();
        this.height = height.FloorU();
    }

    public D2D_SIZE_U(double width, double height)
    {
        this.width = width.FloorU();
        this.height = height.FloorU();
    }

    public override readonly string ToString() => $"{width},{height}";

    public readonly bool IsZero => width == 0 && height == 0;
    public readonly bool IsEmpty => width == 0 || height == 0;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_SIZE_F sz && Equals(sz)) ||
        (obj is SIZE s && Equals(s)) ||
        (obj is D2D_SIZE_U su && Equals(su)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(D2D_SIZE_U other) => width == other.width && height == other.height;
    public override readonly int GetHashCode() => width.GetHashCode() ^ height.GetHashCode();
    public static bool operator ==(D2D_SIZE_U left, D2D_SIZE_U right) => left.Equals(right);
    public static bool operator !=(D2D_SIZE_U left, D2D_SIZE_U right) => !(left == right);

    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(width, height);
    public readonly SIZE ToSize() => new(width, height);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(width, height);
    public readonly Vector2 ToVector2() => new(width, height);

    public readonly D2D_SIZE_U PixelToHiMetric(uint dpi) => new((uint)(D2D_SIZE_F.HIMETRIC_PER_INCH * width / dpi), (uint)(D2D_SIZE_F.HIMETRIC_PER_INCH * height / dpi));
    public readonly D2D_SIZE_U HiMetricToPixel(uint dpi) => new((uint)(width * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH), (uint)(height * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH));

    public static D2D_SIZE_U operator +(D2D_SIZE_U left, D2D_SIZE_U right) => new(left.width + right.width, left.height + right.height);
    public static D2D_SIZE_U operator -(D2D_SIZE_U left, D2D_SIZE_U right) => new(left.width - right.width, left.height - right.height);

    public readonly bool Equals(SIZE other) => width == other.cx && height == other.cy;
    public readonly bool Equals(D2D_SIZE_F other) => width == other.width && height == other.height;
    public readonly bool Equals(D2D_VECTOR_2F other) => width == other.x && height == other.y;
    public readonly bool Equals(Vector2 other) => width == other.X && height == other.Y;

    public static implicit operator D2D_SIZE_U(SIZE pt) => new(pt.cx, pt.cy);
    public static implicit operator D2D_SIZE_U(D2D_VECTOR_2F pt) => new(pt.x, pt.y);
    public static implicit operator D2D_SIZE_U(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator Vector2(D2D_SIZE_U pt) => new(pt.width, pt.height);
    public static implicit operator D2D_SIZE_U(D2D_SIZE_F pt) => new(pt.height, pt.height);
}
