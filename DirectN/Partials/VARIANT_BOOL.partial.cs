namespace DirectN;

public partial struct VARIANT_BOOL : IValueGet<bool>
{
    public static readonly BOOL VARIANT_TRUE = new(true);
    public static readonly BOOL VARIANT_FALSE = new();

    public VARIANT_BOOL(bool value)
    {
        Value = value ? (short)-1 : (short)0;
    }

    readonly bool IValueGet<bool>.GetValue() => Value != 0;

    public static implicit operator VARIANT_BOOL(bool result) => new(result);
    public static implicit operator bool(VARIANT_BOOL b) => b.Value != 0;
}
