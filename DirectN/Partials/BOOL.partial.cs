namespace DirectN;

public partial struct BOOL
{
    public static readonly BOOL TRUE = new(true);
    public static readonly BOOL FALSE = new();

    public BOOL(bool value)
    {
        Value = value ? 1 : 0;
    }

    public override readonly string ToString() => Value != 0 ? "TRUE" : "FALSE";

    public static implicit operator BOOL(bool result) => new(result);
    public static implicit operator bool(BOOL b) => b.Value != 0;
}
