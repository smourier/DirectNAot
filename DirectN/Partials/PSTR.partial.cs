namespace DirectN;

public partial struct PSTR // not disposable as we don't know here who allocated it
{
    public static readonly PSTR Null = new();

    public PSTR(nint value)
    {
        Value = value;
    }

    unsafe public PSTR(char* value)
    {
        Value = (nint)value;
    }

    public PSTR(string value)
    {
        Value = value == null ? 0 : Marshal.StringToCoTaskMemAnsi(value);
    }

    public static void Dispose(ref PSTR pstr)
    {
        var value = Interlocked.Exchange(ref pstr.Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    public override readonly string? ToString() => Marshal.PtrToStringAnsi(Value)!;
}
