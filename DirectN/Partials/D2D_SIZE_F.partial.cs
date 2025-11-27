namespace DirectN;

public partial struct D2D_SIZE_F : IEquatable<D2D_SIZE_U>, IEquatable<D2D_SIZE_F>, IEquatable<SIZE>, IEquatable<Vector2>, IEquatable<D2D_VECTOR_2F>, IParsable<D2D_SIZE_F>
{
    public static D2D_SIZE_F Zero => default;

    public D2D_SIZE_F(float width, float height)
    {
#if DEBUG
        if (width.IsInvalid())
            throw new ArgumentException(null, nameof(width));

        if (height.IsInvalid())
            throw new ArgumentException(null, nameof(height));

        if (width < 0)
            throw new ArgumentException(null, nameof(width));

        if (height < 0)
            throw new ArgumentException(null, nameof(height));

#endif

        this.width = width;
        this.height = height;
    }

    public D2D_SIZE_F(double width, double height)
        : this((float)width, (float)height)
    {
    }

    public override readonly string ToString() => $"{width};{height}";

    public readonly bool IsZero => width == 0 && height == 0;
    public readonly bool IsEmpty => width == 0 || height == 0;
    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => width.IsInvalid() || height.IsInvalid();
    public readonly bool IsSet => width.IsSet() && height.IsSet();
    public readonly bool IsNotSet => width.IsNotSet() || height.IsNotSet();
    public readonly bool IsMax => width.IsMax() || height.IsMax();
    public readonly bool IsMin => width.IsMin() || height.IsMin();

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_SIZE_F sz && Equals(sz)) ||
        (obj is SIZE s && Equals(s)) ||
        (obj is D2D_SIZE_U su && Equals(su)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(D2D_SIZE_F other) => width == other.width && height == other.height;
    public override readonly int GetHashCode() => width.GetHashCode() ^ height.GetHashCode();
    public static bool operator ==(D2D_SIZE_F left, D2D_SIZE_F right) => left.Equals(right);
    public static bool operator !=(D2D_SIZE_F left, D2D_SIZE_F right) => !left.Equals(right);

    public static D2D_SIZE_F operator +(D2D_SIZE_F left, D2D_SIZE_F right) => new(left.width + right.width, left.height + right.height);
    public static D2D_SIZE_F operator -(D2D_SIZE_F left, D2D_SIZE_F right) => new(left.width - right.width, left.height - right.height);

    public readonly D2D_SIZE_U ToD2D_SIZE_U() => new(width.ToUInt32(), height.ToUInt32());
    public readonly SIZE ToSize() => new(width, height);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(width, height);
    public readonly Vector2 ToVector2() => new(width, height);

    public readonly bool Equals(SIZE other) => width == other.cx && height == other.cy;
    public readonly bool Equals(D2D_SIZE_U other) => width == other.width && height == other.height;
    public readonly bool Equals(D2D_VECTOR_2F other) => width == other.x && height == other.y;
    public readonly bool Equals(Vector2 other) => width == other.X && height == other.Y;

    public static implicit operator D2D_SIZE_F(SIZE pt) => new(pt.cx, pt.cy);
    public static implicit operator D2D_SIZE_F(D2D_VECTOR_2F pt) => new(pt.x, pt.y);
    public static implicit operator D2D_SIZE_F(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator Vector2(D2D_SIZE_F pt) => new(pt.width, pt.height);
    public static implicit operator D2D_SIZE_F(D2D_SIZE_U pt) => new(pt.height, pt.height);

#if DEBUG
    public static readonly D2D_SIZE_F Invalid = new() { width = float.NaN, height = float.NaN };
#else
    public static readonly D2D_SIZE_F Invalid = new(float.NaN, float.NaN);
#endif

#if DEBUG
    public static readonly D2D_SIZE_F MaxValue = new() { width = float.MaxValue, height = float.MaxValue };
    public static readonly D2D_SIZE_F PositiveInfinity = new() { width = float.PositiveInfinity, height = float.PositiveInfinity };
#else
    public static readonly D2D_SIZE_F MaxValue = new(float.MaxValue, float.MaxValue);
    public static readonly D2D_SIZE_F PositiveInfinity = new(float.PositiveInfinity, float.PositiveInfinity);
#endif

    public const long HIMETRIC_PER_INCH = 2540;

    public readonly D2D_SIZE_F PixelToHiMetricF() => PixelToHiMetricF(Functions.Dpi);
    public readonly SIZE PixelToHiMetric() => PixelToHiMetric(Functions.Dpi);
    public readonly D2D_SIZE_F HiMetricToPixelF() => HiMetricToPixelF(Functions.Dpi);
    public readonly SIZE HiMetricToPixel() => HiMetricToPixel(Functions.Dpi);
    public readonly D2D_SIZE_F PixelToHiMetricF(D2D_SIZE_F dpi) => new(HIMETRIC_PER_INCH * width / dpi.width, HIMETRIC_PER_INCH * height / dpi.height);
    public readonly SIZE PixelToHiMetric(D2D_SIZE_F dpi) => new((uint)(HIMETRIC_PER_INCH * width / dpi.width), (uint)(HIMETRIC_PER_INCH * height / dpi.height));
    public readonly D2D_SIZE_F HiMetricToPixelF(D2D_SIZE_F dpi) => new(width * dpi.width / HIMETRIC_PER_INCH, height * dpi.height / HIMETRIC_PER_INCH);
    public readonly SIZE HiMetricToPixel(D2D_SIZE_F dpi) => new((uint)(width * dpi.width / HIMETRIC_PER_INCH), (uint)(height * dpi.height / HIMETRIC_PER_INCH));
    public readonly D2D_SIZE_F PixelToHiMetricF(uint dpi) => new(HIMETRIC_PER_INCH * width / dpi, HIMETRIC_PER_INCH * height / dpi);
    public readonly SIZE PixelToHiMetric(uint dpi) => new((uint)(HIMETRIC_PER_INCH * width / dpi), (uint)(HIMETRIC_PER_INCH * height / dpi));
    public readonly D2D_SIZE_F HiMetricToPixelF(uint dpi) => new(width * dpi / HIMETRIC_PER_INCH, height * dpi / HIMETRIC_PER_INCH);
    public readonly SIZE HiMetricToPixel(uint dpi) => new((uint)(width * dpi / HIMETRIC_PER_INCH), (uint)(height * dpi / HIMETRIC_PER_INCH));

    public readonly D2D_SIZE_F PixelToDip()
    {
        var scale = Functions.DpiScale;
        return new D2D_SIZE_F(width / scale.width, height / scale.height);
    }

    public readonly D2D_SIZE_F DipToPixel()
    {
        var scale = Functions.DpiScale;
        return new D2D_SIZE_F(width * scale.width, height * scale.height);
    }

    public static D2D_SIZE_F Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 2)
            throw new FormatException();

        var width = float.Parse(parts[0], provider);
        var height = float.Parse(parts[1], provider);
        return new D2D_SIZE_F(width, height);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out D2D_SIZE_F result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 2)
            return false;

        if (!float.TryParse(parts[0], provider, out var width) ||
            !float.TryParse(parts[1], provider, out var height))
            return false;

        result = new D2D_SIZE_F(width, height);
        return true;
    }
}
