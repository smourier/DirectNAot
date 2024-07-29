namespace DirectN;

[SupportedOSPlatform("windows8.0")]
public partial struct HSTRING
{
    public HSTRING(string? value)
    {
        if (value == null)
        {
            Value = 0;
            return;
        }

        WindowsCreateString(value, (uint)value.Length, out var hs).ThrowOnError();
        Value = hs.Value;
    }

    public static void Dispose(ref HSTRING hstring)
    {
        var value = Interlocked.Exchange(ref hstring.Value, 0);
        if (value != 0)
        {
            Functions.WindowsDeleteString(new HSTRING { Value = value }).ThrowOnError();
        }
    }

    public static unsafe HRESULT WindowsCreateString(string? sourceString, uint length, out HSTRING @string)
    {
        if (sourceString == null)
        {
            @string = new HSTRING(0);
            return Constants.S_OK;
        }

        fixed (char* p = sourceString)
        {
            return Functions.WindowsCreateString(new PWSTR { Value = (nint)p }, length, out @string);
        }
    }

    public unsafe static string? GetString(HSTRING @string)
    {
        if (@string.Value == 0)
            return null;

        uint length;
        var str = (char*)Functions.WindowsGetStringRawBuffer(@string, (nint)(&length)).Value;
        if (str == null)
            return null;

        return new string(str, 0, (int)length);
    }

    public override readonly string? ToString() => GetString(this);
}
