using System.Text;

namespace DirectN;

public partial struct PSTR : IValueGet<string?>, IValueGet<nint> // not disposable as we don't know here who allocated it
{
    public static readonly PSTR Null = new();

    public PSTR(nint value)
    {
        Value = value;
    }

    unsafe public PSTR(byte* value)
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
    // use DirectN.Extensions.Utilities.Pstr if you need to retain it.
    public unsafe static PSTR From(string? str, Encoding? encoding = null)
    {
        if (str == null)
            return Null;

        encoding ??= Encoding.Default;
        var bytes = encoding.GetBytes(str);
        fixed (byte* p = bytes)
        {
            return new PSTR(p);
        }
    }

    public static void Dispose(ref PSTR pstr)
    {
        var value = Interlocked.Exchange(ref pstr.Value, 0);
        if (value != 0)
        {
            Marshal.FreeCoTaskMem(value);
        }
    }

    public override readonly string? ToString() => Marshal.PtrToStringAnsi(Value);
    public readonly string? ToString(int len) => Marshal.PtrToStringAnsi(Value, len);

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
