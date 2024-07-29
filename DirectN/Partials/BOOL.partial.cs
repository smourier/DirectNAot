namespace DirectN;

public partial struct BOOL : IEquatable<BOOL>
{
    public BOOL(bool value)
    {
        Value = value ? 1 : 0;
    }

    public override readonly string ToString() => Value != 0 ? "true" : "false";

    public static implicit operator BOOL(bool result) => new(result);
    public static implicit operator bool(BOOL b) => b.Value != 0;
}
