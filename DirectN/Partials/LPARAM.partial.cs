namespace DirectN;

public partial struct LPARAM
{
    public LPARAM(nint value)
    {
        Value = value;
    }

    public static implicit operator LPARAM(nuint value) => new((nint)value);
    public static implicit operator LPARAM(nint value) => new(value);
    public static implicit operator LPARAM(uint value) => new((nint)value);
    public static implicit operator LPARAM(int value) => new(value);

    public override readonly string ToString() => Value.ToString();
}
