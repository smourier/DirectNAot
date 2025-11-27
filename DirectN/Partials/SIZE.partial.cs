namespace DirectN;

public partial struct SIZE : IEquatable<SIZE>, IEquatable<D2D_SIZE_F>, IEquatable<D2D_SIZE_U>, IEquatable<Vector2>, IEquatable<D2D_VECTOR_2F>, IParsable<SIZE>
{
    public static SIZE Zero => default;

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

    public SIZE(float cx, float cy)
    {
        this.cx = cx.FloorI();
        this.cy = cy.FloorI();
    }

    public SIZE(double cx, double cy)
    {
        this.cx = cx.FloorI();
        this.cy = cy.FloorI();
    }

    public override readonly string ToString() => $"{cx};{cy}";

    public readonly bool IsZero => cx == 0 && cy == 0;
    public readonly bool IsEmpty => cx == 0 || cy == 0;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_SIZE_F sz && Equals(sz)) ||
        (obj is SIZE s && Equals(s)) ||
        (obj is D2D_SIZE_U su && Equals(su)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(SIZE other) => cx == other.cx && cy == other.cy;
    public override readonly int GetHashCode() => cx.GetHashCode() ^ cy.GetHashCode();
    public static bool operator ==(SIZE left, SIZE right) => left.Equals(right);
    public static bool operator !=(SIZE left, SIZE right) => !(left == right);

    public readonly D2D_SIZE_U ToD2D_SIZE_U() => new(cx, cy);
    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(cx, cy);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(cx, cy);
    public readonly Vector2 ToVector2() => new(cx, cy);

    public readonly SIZE PixelToHiMetric(uint dpi) => new((int)(D2D_SIZE_F.HIMETRIC_PER_INCH * cx / dpi), (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * cy / dpi));
    public readonly SIZE HiMetricToPixel(uint dpi) => new((int)(cx * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH), (int)(cy * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH));

    public static SIZE operator +(SIZE left, SIZE right) => new(left.cx + right.cx, left.cy + right.cy);
    public static SIZE operator -(SIZE left, SIZE right) => new(left.cx - right.cx, left.cy - right.cy);

    public readonly bool Equals(D2D_SIZE_U other) => cx == other.width && cy == other.height;
    public readonly bool Equals(D2D_SIZE_F other) => cx == other.width && cy == other.height;
    public readonly bool Equals(D2D_VECTOR_2F other) => cx == other.x && cy == other.y;
    public readonly bool Equals(Vector2 other) => cx == other.X && cy == other.Y;

    public static implicit operator SIZE(D2D_SIZE_U pt) => new(pt.width, pt.height);
    public static implicit operator SIZE(D2D_VECTOR_2F pt) => new(pt.x, pt.y);
    public static implicit operator SIZE(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator Vector2(SIZE pt) => new(pt.cx, pt.cy);
    public static implicit operator SIZE(D2D_SIZE_F pt) => new(pt.height, pt.height);

    public static SIZE Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 2)
            throw new FormatException();

        var cx = int.Parse(parts[0], provider);
        var cy = int.Parse(parts[1], provider);
        return new SIZE(cx, cy);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out SIZE result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 2)
            return false;

        if (!int.TryParse(parts[0], provider, out var cx) ||
            !int.TryParse(parts[1], provider, out var cy))
            return false;

        result = new SIZE(cx, cy);
        return true;
    }
}
