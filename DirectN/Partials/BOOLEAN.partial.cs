namespace DirectN;

public partial struct BOOLEAN
{
    public BOOLEAN(bool value)
    {
        Value = (byte)(value ? 1 : 0);
    }

    public static implicit operator BOOLEAN(bool result) => new(result);
    public static implicit operator bool(BOOLEAN b) => b.Value != 0;
}
