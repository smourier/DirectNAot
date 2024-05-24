﻿using System.Text;

namespace DirectN;

public partial struct PSTR // not disposable as we don't know here who allocated it
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

    public override readonly string? ToString() => Marshal.PtrToStringAnsi(Value);
}
