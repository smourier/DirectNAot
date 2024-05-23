namespace DirectN;

public partial struct D2D_SIZE_F : IEquatable<D2D_SIZE_F>
{
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

    public override readonly string ToString() => "W:" + width + " H:" + height;

    public readonly bool IsZero => width == 0 && height == 0;
    public readonly bool IsEmpty => width == 0 || height == 0;
    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => width.IsInvalid() || height.IsInvalid();
    public readonly bool IsSet => width.IsSet() && height.IsSet();
    public readonly bool IsNotSet => width.IsNotSet() || height.IsNotSet();
    public readonly bool IsMax => width.IsMax() || height.IsMax();
    public readonly bool IsMin => width.IsMin() || height.IsMin();
    public readonly bool Equals(D2D_SIZE_F other) => width == other.width && height == other.height;
    public override readonly bool Equals(object? obj) => (obj is D2D_SIZE_F sz && Equals(sz));
    public override readonly int GetHashCode() => width.GetHashCode() ^ height.GetHashCode();
    public static bool operator ==(D2D_SIZE_F left, D2D_SIZE_F right) => left.Equals(right);
    public static bool operator !=(D2D_SIZE_F left, D2D_SIZE_F right) => !left.Equals(right);
    public static D2D_SIZE_F operator +(D2D_SIZE_F left, D2D_SIZE_F right) => new(left.width + right.width, left.height + right.height);
    public static D2D_SIZE_F operator -(D2D_SIZE_F left, D2D_SIZE_F right) => new(left.width - right.width, left.height - right.height);

    public readonly SIZE ToSize() => new((int)width, (int)height);
    public readonly D2D_SIZE_U ToD2D_SIZE_U() => new(width.ToUInt32(), height.ToUInt32());
    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(width, height);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(width, height);
    public readonly Vector2 ToVector2() => new(width, height);
    public readonly Vector3 ToVector3() => new(width, height, 0);

#if DEBUG
    public static readonly D2D_SIZE_F Invalid = new() { width = float.NaN, height = float.NaN };
#else
    public static readonly D2D_SIZE_F Invalid = new D2D_SIZE_F(float.NaN, float.NaN);
#endif

#if DEBUG
    public static readonly D2D_SIZE_F MaxValue = new() { width = float.MaxValue, height = float.MaxValue };
    public static readonly D2D_SIZE_F PositiveInfinity = new() { width = float.PositiveInfinity, height = float.PositiveInfinity };
#else
    public static readonly D2D_SIZE_F MaxValue = new D2D_SIZE_F(float.MaxValue, float.MaxValue);
    public static readonly D2D_SIZE_F PositiveInfinity = new D2D_SIZE_F(float.PositiveInfinity, float.PositiveInfinity);
#endif

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F PixelToHiMetricF()
    {
        var dpi = Functions.Dpi;
        return new D2D_SIZE_F(SIZE.HIMETRIC_PER_INCH * width / dpi.width, SIZE.HIMETRIC_PER_INCH * height / dpi.height);
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly SIZE PixelToHiMetric()
    {
        var dpi = Functions.Dpi;
        return new SIZE((uint)(SIZE.HIMETRIC_PER_INCH * width / dpi.width), (uint)(SIZE.HIMETRIC_PER_INCH * height / dpi.height));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F HiMetricToPixelF()
    {
        var dpi = Functions.Dpi;
        return new D2D_SIZE_F(width * dpi.width / SIZE.HIMETRIC_PER_INCH, height * dpi.height / SIZE.HIMETRIC_PER_INCH);
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly SIZE HiMetricToPixel()
    {
        var dpi = Functions.Dpi;
        return new SIZE((uint)(width * dpi.width / SIZE.HIMETRIC_PER_INCH), (uint)(height * dpi.height / SIZE.HIMETRIC_PER_INCH));
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F PixelToDip()
    {
        var scale = Functions.DpiScale;
        return new D2D_SIZE_F(width / scale.width, height / scale.height);
    }

    [SupportedOSPlatform("windows6.1")]
    public readonly D2D_SIZE_F DipToPixel()
    {
        var scale = Functions.DpiScale;
        return new D2D_SIZE_F(width * scale.width, height * scale.height);
    }
}
