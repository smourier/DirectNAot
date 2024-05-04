namespace DirectN;

public partial struct POINT : IEquatable<POINT>
{
    public POINT(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public POINT(uint x, uint y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public POINT(float x, float y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public POINT(double x, double y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }

    public override readonly string ToString() => "X:" + x + " Y:" + y;

    public readonly bool IsZero => x == 0 && y == 0;
    public readonly bool Equals(POINT other) => x == other.x && y == other.y;
    public override readonly bool Equals(object? obj) => obj is POINT sz && Equals(sz);
    public override readonly int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
    public static bool operator ==(POINT left, POINT right) => left.Equals(right);
    public static bool operator !=(POINT left, POINT right) => !left.Equals(right);
    public static POINT operator +(POINT left, POINT right) => new(left.x + right.x, left.y + right.y);
    public static POINT operator -(POINT left, POINT right) => new(left.x - right.x, left.y - right.y);
}
