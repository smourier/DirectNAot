namespace DirectN;

public partial struct PWSTR : IDisposable
{
    public PWSTR(nint value)
    {
        Value = value;
    }

    public PWSTR(string value)
    {
        Value = value == null ? 0 : Marshal.StringToHGlobalUni(value);
    }

    public void Dispose()
    {
        var value = Interlocked.Exchange(ref Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    public static implicit operator PWSTR(char value) => new(value.ToString());
    public static implicit operator PWSTR(string value) => new(value);
}
