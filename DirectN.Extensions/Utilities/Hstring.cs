namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows8.0")]
public class Hstring : IDisposable
{
    public nint Value;

    protected Hstring() { }

    public Hstring(nint value)
    {
        Value = value;
    }

    public Hstring(string? value)
    {
        if (value == null)
        {
            Value = 0;
            return;
        }

        HSTRING.WindowsCreateString(value, (uint)value.Length, out var hs).ThrowOnError();
        Value = hs.Value;
    }

    public Hstring(string? value, uint length)
    {
        if (value == null)
        {
            Value = 0;
            return;
        }

        HSTRING.WindowsCreateString(value, length, out var hs).ThrowOnError();
        Value = hs.Value;
    }

    public int? Length => ToString()?.Length;

    public override string? ToString() => HSTRING.GetString(new HSTRING { Value = Value });

    public static implicit operator Hstring(string? value) => new(value);
    public static implicit operator HSTRING(Hstring value) => new() { Value = value.Value };
    public static implicit operator Hstring(HSTRING value) => new() { Value = value.Value };

    protected virtual void Dispose(bool disposing)
    {
        var value = Interlocked.Exchange(ref Value, 0);
        if (value != 0)
        {
            Functions.WindowsDeleteString(new HSTRING { Value = value }).ThrowOnError();
        }
    }

    ~Hstring() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
