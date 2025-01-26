namespace DirectN.Extensions.Utilities;

public class Pstr : IDisposable
{
    public nint Value;

    protected Pstr() { }

    public Pstr(nint value)
    {
        Value = value;
    }

    unsafe public Pstr(byte* value)
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

    public Pstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public Pstr(uint sizeInBytes)
    {
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public Pstr(string? value, Encoding? encoding = null)
    {
        if (value == null)
        {
            Value = 0;
            return;
        }

        encoding ??= Encoding.Default;
        var bytes = encoding.GetBytes(value + "\0");
        Value = Marshal.AllocCoTaskMem(bytes.Length);
        Marshal.Copy(bytes, 0, Value, bytes.Length);
    }

    public override string? ToString() => Marshal.PtrToStringAnsi(Value)!;

    public static implicit operator Pstr(string? value) => new(value);
    public static implicit operator PSTR(Pstr value) => new(value.Value);
    public static implicit operator Pstr(PSTR value) => new(value.Value);

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
