namespace DirectN.Extensions.Utilities;

public class Pwstr : IDisposable
{
    public nint Value;

    protected Pwstr() { }

    public Pwstr(nint value)
    {
        Value = value;
    }

    unsafe public Pwstr(char* value)
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

    public Pwstr(string? value)
    {
        Value = value == null ? 0 : Marshal.StringToCoTaskMemUni(value);
    }

    public int? Length => ToString()?.Length;

    public override string? ToString() => Marshal.PtrToStringUni(Value)!;

    public static implicit operator Pwstr(string? value) => new(value);
    public static implicit operator PWSTR(Pwstr value) => new(value.Value);
    public static implicit operator Pwstr(PWSTR value) => new(value.Value);

    protected virtual void Dispose(bool disposing)
    {
        var value = Interlocked.Exchange(ref Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    ~Pwstr() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
