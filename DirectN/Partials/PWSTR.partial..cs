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

    // immediate native calls generally works because the backing memory has not moved or been reclaimed, but it is no longer pinned.
    // do not retain the returned pointer, immediate use is not guaranteed safe if a garbage collection can occur in your context.
    // use DirectN.Extensions.Utilities.Pwstr if you need to retain it.
    public unsafe static PWSTR From(string? str)
    {
        if (str == null)
            return Null;

        fixed (char* chars = str)
        {
            return new PWSTR(chars);
        }
    }

    public static void Dispose(ref PWSTR pwstr)
    {
        var value = Interlocked.Exchange(ref pwstr.Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    public override readonly string? ToString() => Marshal.PtrToStringUni(Value);
    public readonly string? ToString(int len) => Marshal.PtrToStringUni(Value, len);

    public string? ToStringAndDispose()
    {
        var str = ToString();
        Dispose(ref this);
        return str;
    }

    public string? ToStringAndDispose(int len)
    {
        var str = ToString(len);
        Dispose(ref this);
        return str;
    }

    readonly string? IValueGet<string?>.GetValue() => ToString();
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => ToString();
}
