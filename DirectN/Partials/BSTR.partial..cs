namespace DirectN;

public partial struct BSTR : IValueGet<string?>, IValueGet<nint> // not disposable as we don't know here who allocated it
{
    public static readonly BSTR Null = new();

    public BSTR(nint value)
    {
        Value = value;
    }

    unsafe public BSTR(char* value)
    {
        Value = (nint)value;
    }

    public static void Dispose(ref BSTR bstr)
    {
        var value = Interlocked.Exchange(ref bstr.Value, 0);
        if (value != 0)
        {
            Marshal.FreeBSTR(value);
        }
    }

    public override readonly string? ToString() => Marshal.PtrToStringBSTR(Value);

    readonly string? IValueGet<string?>.GetValue() => ToString();
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => ToString();
}
