namespace DirectN;

public partial struct PWSTR // not disposable as we don't know here who allocated it
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

    public PWSTR(string? value)
    {
        Value = value == null ? 0 : Marshal.StringToCoTaskMemUni(value);
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
}
