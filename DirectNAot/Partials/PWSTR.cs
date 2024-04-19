namespace DirectN;

public partial struct PWSTR // not disposable as we don't know here who allocated it
{
    public PWSTR(nint value)
    {
        Value = value;
    }

    public PWSTR(string value)
    {
        Value = value == null ? 0 : Marshal.StringToHGlobalUni(value);
    }

    public static void Dispose(ref PWSTR pwstr)
    {
        var value = Interlocked.Exchange(ref pwstr.Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    public override readonly string ToString() => Marshal.PtrToStringUni(Value)!;

    public static implicit operator PWSTR(char value) => new(value.ToString());
    public static implicit operator PWSTR(string value) => new(value);
}
