namespace DirectN;

public partial struct PWSTR : IValueGet<string?>, IValueGet<nint> // not disposable as we don't know here who allocated it
{
    public static readonly PWSTR Null = new();

    public PWSTR(nint value)
    {
        Value = value;
    }

    unsafe public PWSTR(char* value)
    {
        if (value != null)
        {
            Value = (nint)value;
        }
        else
        {
            Value = 0;
        }
    }

    public unsafe static PWSTR From(string? str)
    {
        if (str == null)
            return Null;

        fixed (char* chars = str)
        {
            return new PWSTR(chars);
        }
    }

    public override readonly string? ToString() => Marshal.PtrToStringUni(Value);

    readonly string? IValueGet<string?>.GetValue() => ToString();
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => ToString();
}
