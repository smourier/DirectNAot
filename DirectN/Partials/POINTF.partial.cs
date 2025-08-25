namespace DirectN;

public partial struct POINTF : IEquatable<D2D_POINT_2F>, IEquatable<D2D_VECTOR_2F>, IEquatable<D2D_POINT_2U>, IEquatable<POINTF>, IEquatable<Vector2>
{
    public static POINTF Zero => default;

    public POINTF(int x, int y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public POINTF(uint x, uint y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public POINTF(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public POINTF(double x, double y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public override readonly string ToString() => $"{x},{y}";

    public readonly bool IsZero => x == 0 && y == 0;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_POINT_2F sz && Equals(sz)) ||
        (obj is D2D_VECTOR_2F vc && Equals(vc)) ||
        (obj is D2D_POINT_2U pu && Equals(pu)) ||
        (obj is POINTF ptf && Equals(ptf)) ||
        (obj is POINT pt && Equals(pt)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(POINTF other) => x == other.x && y == other.y;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(POINTF left, POINTF right) => left.Equals(right);
    public static bool operator !=(POINTF left, POINTF right) => !left.Equals(right);

    public readonly POINT ToPOINT() => new(x, y);
    public readonly D2D_POINT_2F ToD2D_POINT_2F() => new(x, y);
    public readonly D2D_POINT_2U ToD2D_POINT_2U() => new(x, y);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(x, y);
    public readonly Vector2 ToVector2() => new(x, y);

    public static POINTF operator +(POINTF left, POINTF right) => new(left.x + right.x, left.y + right.y);
    public static POINTF operator -(POINTF left, POINTF right) => new(left.x - right.x, left.y - right.y);

    public readonly bool Equals(POINT other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_POINT_2U other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(Vector2 other) => x == other.Y && y == other.Y;

    public static implicit operator POINTF(POINT vc) => new(vc.x, vc.y);
    public static implicit operator POINTF(D2D_VECTOR_2F vc) => new(vc.x, vc.y);
    public static implicit operator POINTF(D2D_POINT_2U pt) => new(pt.x, pt.y);
    public static implicit operator Vector2(POINTF pt) => new(pt.x, pt.y);
    public static implicit operator POINTF(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator POINTF(D2D_POINT_2F pt) => new(pt.x, pt.y);
}
