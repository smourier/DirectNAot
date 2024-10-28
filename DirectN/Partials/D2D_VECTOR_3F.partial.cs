namespace DirectN;

public partial struct D2D_VECTOR_3F : IEquatable<D2D_VECTOR_3F>, IEquatable<Vector3>
{
    public static D2D_VECTOR_3F Zero => default;

    public D2D_VECTOR_3F(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public D2D_VECTOR_3F(double x, double y, double z)
    {
        this.x = (float)x;
        this.y = (float)y;
        this.z = (float)z;
    }

    public override readonly string ToString() => $"{x},{y},{z}";

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid() || z.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet() && z.IsSet();
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet() || z.IsNotSet();
    public readonly float Length => (float)Math.Sqrt(x * x + y * y + z * z);

    public readonly float[] ToArray() => [x, y, z];
    public readonly D2D_VECTOR_3F Normalize() { var len = Length; if (len == 0) return this; return new D2D_VECTOR_3F(x / len, y / len, z / len); }
    public readonly float Dot(D2D_VECTOR_3F right) => x * right.x + y * right.y + z * right.z;
    public readonly D2D_VECTOR_3F Cross(D2D_VECTOR_3F right) => new(y * right.z - z * right.y, z * right.x - x * right.z, x * right.y - y * right.x);

    public override readonly bool Equals(object? obj) => (obj is D2D_VECTOR_3F sz && Equals(sz)) || (obj is Vector3 v3 && Equals(v3));
    public readonly bool Equals(D2D_VECTOR_3F other) => x == other.x && y == other.y && z == other.z;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
    public static bool operator ==(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => left.Equals(right);
    public static bool operator !=(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => !(left == right);

    public readonly Vector3 ToVector3() => new(x, y, z);

    public static D2D_VECTOR_3F operator +(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => new(left.x + right.x, left.y + right.y, left.z + right.z);
    public static D2D_VECTOR_3F operator -(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => new(left.x - right.x, left.y - right.y, left.z - right.z);
    public static D2D_VECTOR_3F operator *(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => new(left.x * right.x, left.y * right.y, left.z * right.z);
    public static D2D_VECTOR_3F operator /(D2D_VECTOR_3F left, D2D_VECTOR_3F right) => new(left.x / right.x, left.y / right.y, left.z / right.z);

    public readonly bool Equals(Vector3 other) => x == other.Y && y == other.Y && z == other.Z;

    public static implicit operator D2D_VECTOR_3F(Vector3 vc) => new(vc.X, vc.Y, vc.Z);
    public static implicit operator Vector3(D2D_VECTOR_3F vc) => new(vc.x, vc.y, vc.z);
}
