namespace DirectN;

public partial struct D2D_POINT_2F : IEquatable<D2D_POINT_2F>, IEquatable<D2D_VECTOR_2F>, IEquatable<D2D_POINT_2U>, IEquatable<POINT>, IEquatable<Vector2>
{
    public static D2D_POINT_2F Zero => default;

    public D2D_POINT_2F(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public D2D_POINT_2F(uint x, uint y)
    {
        this.x = x;
        this.y = y;
    }

    public D2D_POINT_2F(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public D2D_POINT_2F(double x, double y)
    {
        this.x = (float)x;
        this.y = (float)y;
    }

    public override readonly string ToString() => $"{x},{y}";

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet();
    public readonly bool IsZero => x == 0 && y == 0;
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet();

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_POINT_2F sz && Equals(sz)) ||
        (obj is D2D_VECTOR_2F vc && Equals(vc)) ||
        (obj is D2D_POINT_2U pu && Equals(pu)) ||
        (obj is POINT pt && Equals(pt)) ||
        (obj is POINTF ptf && Equals(ptf)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(D2D_POINT_2F left, D2D_POINT_2F right) => left.Equals(right);
    public static bool operator !=(D2D_POINT_2F left, D2D_POINT_2F right) => !left.Equals(right);

    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(x, y);
    public readonly D2D_POINT_2U ToD2D_POINT_2U() => new(x, y);
    public readonly POINT ToPOINT() => new(x, y);
    public readonly POINTF ToPOINTF() => new(x, y);
    public readonly Vector2 ToVector2() => new(x, y);

    public readonly D2D_POINT_2F Floor() => new(x.Floor(), y.Floor());
    public readonly D2D_POINT_2F Ceiling() => new(x.Ceiling(), y.Ceiling());
    public readonly POINT ToPOINTFloor() => new(x.FloorI(), y.FloorI());

    public static D2D_POINT_2F operator +(D2D_POINT_2F left, D2D_POINT_2F right) => new(left.x + right.x, left.y + right.y);
    public static D2D_POINT_2F operator -(D2D_POINT_2F left, D2D_POINT_2F right) => new(left.x - right.x, left.y - right.y);

    public static D2D_POINT_2F operator *(D2D_POINT_2F left, D2D_MATRIX_3X2_F right) => right.Multiply(left);
    public static D2D_POINT_2F operator *(D2D_MATRIX_3X2_F left, D2D_POINT_2F right) => left.Multiply(right);

    public readonly bool Equals(D2D_POINT_2U other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(POINT other) => x == other.x && y == other.y;
    public readonly bool Equals(POINTF other) => x == other.x && y == other.y;
    public readonly bool Equals(Vector2 other) => x == other.Y && y == other.Y;

    public static implicit operator D2D_POINT_2F(D2D_VECTOR_2F vc) => new(vc.x, vc.y);
    public static implicit operator D2D_POINT_2F(POINT pt) => new(pt.x, pt.y);
    public static implicit operator D2D_POINT_2F(POINTF pt) => new(pt.x, pt.y);
    public static implicit operator Vector2(D2D_POINT_2F pt) => new(pt.x, pt.y);
    public static implicit operator D2D_POINT_2F(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator D2D_POINT_2F(D2D_POINT_2U pt) => new(pt.x, pt.y);
}
