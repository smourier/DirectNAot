namespace DirectN;

public partial struct D2D_VECTOR_4F : IEquatable<D2D_VECTOR_4F>
{
    public D2D_VECTOR_4F(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public override readonly string ToString() => "X:" + x + " Y:" + y + " Z:" + z + " W:" + w;

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid() || z.IsInvalid() || w.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet() && z.IsSet() && w.IsSet();
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet() || z.IsNotSet() || w.IsNotSet();
    public readonly float Length => (float)Math.Sqrt(x * x + y * y + z * z + w * w);
    public readonly bool Equals(D2D_VECTOR_4F other) => x == other.x && y == other.y && z == other.z && w == other.w;
    public readonly float[] ToArray() => [x, y, z, w];
    public readonly D2D_VECTOR_4F Normalize()
    {
        var len = Length;
        if (len == 0)
            return this;

        return new D2D_VECTOR_4F(x / len, y / len, z / len, w / len);
    }

    public readonly float Dot(D2D_VECTOR_4F right) => x * right.x + y * right.y + z * right.z + x * right.w;
    public override readonly bool Equals(object? obj) => obj is D2D_VECTOR_4F sz && Equals(sz);
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
    public static bool operator ==(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => left.Equals(right);
    public static bool operator !=(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => !(left == right);
    public static D2D_VECTOR_4F operator +(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.x);
    public static D2D_VECTOR_4F operator -(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.x);
    public static D2D_VECTOR_4F operator *(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.x);
    public static D2D_VECTOR_4F operator /(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.x);
}
