namespace DirectNAot.Extensions.Utilities;

public class Pstr : IDisposable
{
    public nint Value;

    protected Pstr() { }

    public Pstr(nint value)
    {
        Value = value;
    }

    public Pstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public Pstr(uint sizeInBytes)
    {
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public Pstr(string? value)
    {
        Value = value == null ? 0 : Marshal.StringToCoTaskMemAnsi(value);
    }

    public override string? ToString() => Marshal.PtrToStringAnsi(Value)!;

    public static implicit operator Pstr(string value) => new(value);
    public static implicit operator PSTR(Pstr value) => new(value.Value);

    protected virtual void Dispose(bool disposing)
    {
        var value = Interlocked.Exchange(ref Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    ~Pstr() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
