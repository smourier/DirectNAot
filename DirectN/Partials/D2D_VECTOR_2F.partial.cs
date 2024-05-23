namespace DirectN;

public partial struct D2D_VECTOR_2F : IEquatable<D2D_VECTOR_2F>
{
    public D2D_VECTOR_2F(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override readonly string ToString() => "X:" + x + " Y:" + y;

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet();
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet();
    public readonly float Length => (float)Math.Sqrt(x * x + y * y);
    public readonly bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
    public readonly float[] ToArray() => [x, y];
    public readonly D2D_VECTOR_2F Normalize()
    {
        var len = Length;
        if (len == 0)
            return this;

        return new D2D_VECTOR_2F(x / len, y / len);
    }

    public readonly float Dot(D2D_VECTOR_2F right) => x * right.x + y * right.y;
    public override readonly bool Equals(object? obj) => obj is D2D_VECTOR_2F sz && Equals(sz);
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => left.Equals(right);
    public static bool operator !=(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => !(left == right);
    public static D2D_VECTOR_2F operator +(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x + right.x, left.y + right.y);
    public static D2D_VECTOR_2F operator -(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x - right.x, left.y - right.y);
    public static D2D_VECTOR_2F operator *(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x * right.x, left.y * right.y);
    public static D2D_VECTOR_2F operator /(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x / right.x, left.y / right.y);
    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(x, y);
    public readonly Vector2 ToVector2() => new(x, y);
    public readonly Vector3 ToVector3() => new(x, y, 0);
    public static D2D_VECTOR_2F From(Vector2 value) => new(value.X, value.Y);
}
