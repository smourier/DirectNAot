namespace DirectN.Extensions.Utilities;

public class Bstr : IDisposable
{
    public nint Value;

    protected Bstr() { }

    public Bstr(nint value)
    {
        Value = value;
    }

    public Bstr(string? value)
    {
        Value = value == null ? 0 : Marshal.StringToBSTR(value);
    }

    public int? Length => ToString()?.Length;
    public BSTR BSTR => new(Value);

    public override string? ToString() => Marshal.PtrToStringBSTR(Value)!;

    public static implicit operator Bstr(string? value) => new(value);
    public static implicit operator BSTR(Bstr value) => new(value.Value);
    public static implicit operator Bstr(BSTR value) => new(value.Value);

    protected virtual void Dispose(bool disposing)
    {
        var value = Interlocked.Exchange(ref Value, 0);
        if (value != 0)
        {
            Marshal.FreeBSTR(value);
        }
    }

    ~Bstr() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}