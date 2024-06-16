namespace DirectN;

public partial struct BOOL : IEquatable<BOOL>
{
    public BOOL(int value)
    {
        Value = value;
    }

    public BOOL(bool value)
    {
        Value = value ? 1 : 0;
    }

    public override readonly bool Equals(object? obj) => Value.Equals(obj);
    public override readonly int GetHashCode() => Value.GetHashCode();
    public readonly bool Equals(BOOL other) => Value.Equals(other.Value);

    public override readonly string ToString() => Value != 0 ? "true" : "false";

    public static bool operator ==(BOOL left, BOOL right) => left.Value == right.Value;
    public static bool operator !=(BOOL left, BOOL right) => left.Value != right.Value;

    public static implicit operator BOOL(int value) => new(value);
    public static implicit operator int(BOOL b) => b.Value;
    public static implicit operator BOOL(bool result) => new(result);
    public static implicit operator bool(BOOL b) => b.Value != 0;
}
