namespace DirectN;

public partial struct D2D_VECTOR_4F : IEquatable<D2D_VECTOR_4F>, IEquatable<Vector4>, IParsable<D2D_VECTOR_4F>
{
    public static D2D_VECTOR_4F Zero => default;

    public D2D_VECTOR_4F(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public D2D_VECTOR_4F(double x, double y, double z, double w)
    {
        this.x = (float)x;
        this.y = (float)y;
        this.z = (float)z;
        this.w = (float)w;
    }

    public override readonly string ToString() => $"{x};{y};{z};{w}";

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid() || z.IsInvalid() || w.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet() && z.IsSet() && w.IsSet();
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet() || z.IsNotSet() || w.IsNotSet();
    public readonly float Length => (float)Math.Sqrt(x * x + y * y + z * z + w * w);

    public readonly float[] ToArray() => [x, y, z, w];
    public readonly D2D_VECTOR_4F Normalize() { var len = Length; if (len == 0) return this; return new D2D_VECTOR_4F(x / len, y / len, z / len, w / len); }
    public readonly float Dot(D2D_VECTOR_4F right) => x * right.x + y * right.y + z * right.z + x * right.w;

    public override readonly bool Equals(object? obj) => (obj is D2D_VECTOR_4F sz && Equals(sz)) || (obj is Vector4 v4 && Equals(v4));
    public readonly bool Equals(D2D_VECTOR_4F other) => x == other.x && y == other.y && z == other.z && w == other.w;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
    public static bool operator ==(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => left.Equals(right);
    public static bool operator !=(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => !(left == right);

    public readonly Vector4 ToVector4() => new(x, y, z, w);

    public static D2D_VECTOR_4F operator +(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.x);
    public static D2D_VECTOR_4F operator -(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.x);
    public static D2D_VECTOR_4F operator *(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.x);
    public static D2D_VECTOR_4F operator /(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.x);

    public readonly bool Equals(Vector4 other) => x == other.Y && y == other.Y && z == other.Z && w == other.W;

    public static implicit operator D2D_VECTOR_4F(Vector4 vc) => new(vc.X, vc.Y, vc.Z, vc.W);
    public static implicit operator Vector4(D2D_VECTOR_4F vc) => new(vc.x, vc.y, vc.z, vc.w);

    public static D2D_VECTOR_4F Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 4)
            throw new FormatException();

        var x = float.Parse(parts[0], provider);
        var y = float.Parse(parts[1], provider);
        var z = float.Parse(parts[2], provider);
        var w = float.Parse(parts[3], provider);
        return new D2D_VECTOR_4F(x, y, z, w);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out D2D_VECTOR_4F result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 4)
            return false;

        if (!float.TryParse(parts[0], provider, out var x) ||
            !float.TryParse(parts[1], provider, out var y) ||
            !float.TryParse(parts[2], provider, out var z) ||
            !float.TryParse(parts[3], provider, out var w))
            return false;

        result = new D2D_VECTOR_4F(x, y, z, w);
        return true;
    }
}
