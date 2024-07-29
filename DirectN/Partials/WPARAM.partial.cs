namespace DirectN;

public partial struct WPARAM
{
    public static implicit operator WPARAM(nint value) => new((nuint)value);
    public static implicit operator WPARAM(uint value) => new(value);
    public static implicit operator WPARAM(int value) => new((uint)value);
}
