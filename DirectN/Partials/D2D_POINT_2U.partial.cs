﻿namespace DirectN;

public partial struct D2D_POINT_2U : IEquatable<D2D_POINT_2F>, IEquatable<D2D_VECTOR_2F>, IEquatable<D2D_POINT_2U>, IEquatable<POINT>, IEquatable<Vector2>
{
    public static D2D_POINT_2U Zero => default;

    public D2D_POINT_2U(int x, int y)
    {
        this.x = (uint)x;
        this.y = (uint)y;
    }

    public D2D_POINT_2U(uint x, uint y)
    {
        this.x = x;
        this.y = y;
    }

    public D2D_POINT_2U(float x, float y)
    {
        this.x = x.FloorU();
        this.y = y.FloorU();
    }

    public D2D_POINT_2U(double x, double y)
    {
        this.x = x.FloorU();
        this.y = y.FloorU();
    }

    public override readonly string ToString() => $"{x},{y}";

    public readonly bool IsZero => x == 0 && y == 0;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_POINT_2F sz && Equals(sz)) ||
        (obj is D2D_VECTOR_2F vc && Equals(vc)) ||
        (obj is D2D_POINT_2U pu && Equals(pu)) ||
        (obj is POINT pt && Equals(pt)) ||
        (obj is Vector2 v2 && Equals(v2));
    public readonly bool Equals(D2D_POINT_2U other) => x == other.x && y == other.y;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(D2D_POINT_2U left, D2D_POINT_2U right) => left.Equals(right);
    public static bool operator !=(D2D_POINT_2U left, D2D_POINT_2U right) => !left.Equals(right);

    public readonly D2D_POINT_2F ToD2D_POINT_2F() => new(x, y);
    public readonly D2D_VECTOR_2F ToD2D_VECTOR_2F() => new(x, y);
    public readonly POINT ToPOINT() => new(x, y);
    public readonly Vector2 ToVector2() => new(x, y);

    public static D2D_POINT_2U operator +(D2D_POINT_2U left, D2D_POINT_2U right) => new(left.x + right.x, left.y + right.y);
    public static D2D_POINT_2U operator -(D2D_POINT_2U left, D2D_POINT_2U right) => new(left.x - right.x, left.y - right.y);

    public readonly bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(POINT other) => x == other.x && y == other.y;
    public readonly bool Equals(Vector2 other) => x == other.Y && y == other.Y;

    public static implicit operator D2D_POINT_2U(D2D_VECTOR_2F vc) => new(vc.x, vc.y);
    public static implicit operator D2D_POINT_2U(POINT pt) => new(pt.x, pt.y);
    public static implicit operator Vector2(D2D_POINT_2U pt) => new(pt.x, pt.y);
    public static implicit operator D2D_POINT_2U(Vector2 pt) => new(pt.X, pt.Y);
    public static implicit operator D2D_POINT_2U(D2D_POINT_2F pt) => new(pt.x, pt.y);
}
