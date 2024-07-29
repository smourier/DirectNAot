namespace DirectN;

public partial struct LPARAM
{
    public static implicit operator LPARAM(nuint value) => new((nint)value);
    public static implicit operator LPARAM(uint value) => new((nint)value);
    public static implicit operator LPARAM(int value) => new(value);
}
