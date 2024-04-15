namespace DirectN;

public partial struct HRESULT : IEquatable<HRESULT>
{
    public HRESULT(int value)
    {
        Value = value;
    }

    public HRESULT(uint value)
        : this((int)value)
    {
    }

    public readonly uint UValue => (uint)Value;

    public override readonly bool Equals(object? obj) => Value.Equals(obj);
    public override readonly int GetHashCode() => Value.GetHashCode();
    public readonly bool Equals(HRESULT other) => Value.Equals(other.Value);

    public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;
    public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

    public static implicit operator HRESULT(int value) => new(value);
    public static implicit operator HRESULT(uint result) => new(result);

    public static explicit operator uint(HRESULT hr) => hr.UValue;
    public static explicit operator int(HRESULT hr) => hr.Value;
}
