namespace DirectN;

public partial struct D2D_VECTOR_2F :
    IEquatable<SIZE>,
    IEquatable<D2D_SIZE_F>,
    IEquatable<D2D_SIZE_U>,
    IEquatable<Vector2>,
    IEquatable<D2D_VECTOR_2F>,
    IEquatable<D2D_POINT_2F>,
    IEquatable<D2D_POINT_2U>,
    IEquatable<POINT>,
    IParsable<D2D_VECTOR_2F>
{
    public static D2D_VECTOR_2F Zero => default;

    public D2D_VECTOR_2F(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public D2D_VECTOR_2F(double x, double y)
    {
        this.x = (float)x;
        this.y = (float)y;
    }

    public override readonly string ToString() => $"{x};{y}";

    public readonly bool IsValid => !IsInvalid;
    public readonly bool IsInvalid => x.IsInvalid() || y.IsInvalid();
    public readonly bool IsSet => x.IsSet() && y.IsSet();
    public readonly bool IsNotSet => x.IsNotSet() || y.IsNotSet();
    public readonly float Length => (float)Math.Sqrt(x * x + y * y);

    public readonly float[] ToArray() => [x, y];
    public readonly D2D_VECTOR_2F Normalize() { var len = Length; if (len == 0) return this; return new D2D_VECTOR_2F(x / len, y / len); }
    public readonly float Dot(D2D_VECTOR_2F right) => x * right.x + y * right.y;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_VECTOR_2F v && Equals(v)) ||
        (obj is Vector2 v2 && Equals(v2)) ||
        (obj is D2D_SIZE_F sz && Equals(sz)) ||
        (obj is D2D_SIZE_U su && Equals(su)) ||
        (obj is SIZE s && Equals(s)) ||
        (obj is D2D_POINT_2F pf && Equals(pf)) ||
        (obj is D2D_POINT_2U pu && Equals(pu)) ||
        (obj is POINTF ptf && Equals(ptf)) ||
        (obj is POINT p && Equals(p));
    public readonly bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => left.Equals(right);
    public static bool operator !=(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => !(left == right);

    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(x, y);
    public readonly D2D_SIZE_U ToD2D_SIZE_U() => new(x, y);
    public readonly SIZE ToSIZE() => new(x, y);
    public readonly POINT ToPOINT() => new(x, y);
    public readonly POINTF ToPOINTF() => new(x, y);
    public readonly D2D_POINT_2F ToD2D_POINT_2F() => new(x, y);
    public readonly D2D_POINT_2U ToD2D_POINT_2U() => new(x, y);
    public readonly Vector2 ToVector2() => new(x, y);

    public static D2D_VECTOR_2F operator +(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x + right.x, left.y + right.y);
    public static D2D_VECTOR_2F operator -(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x - right.x, left.y - right.y);
    public static D2D_VECTOR_2F operator *(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x * right.x, left.y * right.y);
    public static D2D_VECTOR_2F operator /(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => new(left.x / right.x, left.y / right.y);

    public readonly bool Equals(D2D_POINT_2U other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;
    public readonly bool Equals(POINT other) => x == other.x && y == other.y;
    public readonly bool Equals(POINTF other) => x == other.x && y == other.y;
    public readonly bool Equals(D2D_SIZE_F other) => x == other.width && y == other.height;
    public readonly bool Equals(D2D_SIZE_U other) => x == other.width && y == other.height;
    public readonly bool Equals(SIZE other) => x == other.cx && y == other.cy;
    public readonly bool Equals(Vector2 other) => x == other.Y && y == other.Y;

    public static implicit operator D2D_VECTOR_2F(Vector2 vc) => new(vc.X, vc.Y);
    public static implicit operator Vector2(D2D_VECTOR_2F vc) => new(vc.x, vc.y);
    public static implicit operator D2D_VECTOR_2F(D2D_SIZE_F vc) => new(vc.width, vc.height);
    public static implicit operator D2D_VECTOR_2F(D2D_SIZE_U vc) => new(vc.width, vc.height);
    public static implicit operator D2D_VECTOR_2F(SIZE vc) => new(vc.cx, vc.cy);
    public static implicit operator D2D_VECTOR_2F(POINT vc) => new(vc.x, vc.y);
    public static implicit operator D2D_VECTOR_2F(POINTF vc) => new(vc.x, vc.y);
    public static implicit operator D2D_VECTOR_2F(D2D_POINT_2F vc) => new(vc.x, vc.y);
    public static implicit operator D2D_VECTOR_2F(D2D_POINT_2U vc) => new(vc.x, vc.y);

    public static D2D_VECTOR_2F Parse(string s, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        var parts = s.Split(';');
        if (parts.Length != 2)
            throw new FormatException();

        var x = float.Parse(parts[0], provider);
        var y = float.Parse(parts[1], provider);
        return new D2D_VECTOR_2F(x, y);
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out D2D_VECTOR_2F result)
    {
        result = default;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        var parts = s.Split(';');
        if (parts.Length != 2)
            return false;

        if (!float.TryParse(parts[0], provider, out var x) ||
            !float.TryParse(parts[1], provider, out var y))
            return false;

        result = new D2D_VECTOR_2F(x, y);
        return true;
    }
}
