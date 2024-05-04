namespace DirectN;

public partial struct D2D_SIZE_U : IEquatable<D2D_SIZE_U>
{
    public D2D_SIZE_U(uint width, uint height)
    {
        this.width = width;
        this.height = height;
    }

    public override readonly string ToString() => "W:" + width + " H:" + height;

    public readonly bool IsZero => width == 0 && height == 0;
    public readonly bool IsEmpty => width == 0 || height == 0;
    public readonly bool Equals(D2D_SIZE_U other) => width == other.width && height == other.height;
    public override readonly bool Equals(object? obj) => obj is D2D_SIZE_U sz && Equals(sz);
    public override readonly int GetHashCode() => width.GetHashCode() ^ height.GetHashCode();
    public static bool operator ==(D2D_SIZE_U left, D2D_SIZE_U right) => left.Equals(right);
    public static bool operator !=(D2D_SIZE_U left, D2D_SIZE_U right) => !(left == right);
    public readonly SIZE ToSize() => new((int)width, (int)height);
    public readonly D2D_SIZE_F ToD2D_SIZE_F() => new(width, height);
}
