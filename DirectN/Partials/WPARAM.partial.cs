namespace DirectN;

public partial struct WPARAM
{
    public WPARAM(nuint value)
    {
        Value = value;
    }

    public static implicit operator WPARAM(nuint value) => new(value);
    public static implicit operator WPARAM(nint value) => new((nuint)value);
    public static implicit operator WPARAM(uint value) => new(value);
    public static implicit operator WPARAM(int value) => new((uint)value);

    public override readonly string ToString() => Value.ToString();
}
