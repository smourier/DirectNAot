using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace DirectN;

public partial struct HRESULT : IEquatable<HRESULT>, IFormattable
{
    private static readonly ConcurrentDictionary<int, string?> _names = new();

    public HRESULT(int value)
    {
        Value = value;
    }

    public HRESULT(uint value)
        : this((int)value)
    {
    }

    public readonly uint UValue => (uint)Value;
    public readonly string Name => ToString("n", null);
    public readonly bool IsError => Value < 0;
    public readonly bool IsSuccess => Value >= 0;
    public readonly bool IsOk => Value == 0;
    public readonly bool IsFalse => Value == 1;

    public readonly HRESULT ThrowOnError(bool throwOnError = true) => ThrowOnErrorExcept(null, throwOnError);
    public readonly HRESULT ThrowOnErrorExcept(HRESULT exceptedValue, bool throwOnError = true) => ThrowOnErrorExcept([exceptedValue], throwOnError);
    public readonly HRESULT ThrowOnErrorExcept(IEnumerable<HRESULT>? exceptedValues, bool throwOnError = true)
    {
        if (!throwOnError)
            return Value;

        if (exceptedValues != null && exceptedValues.Contains(this))
            return Value;

        var exception = GetException();
        if (exception != null)
            throw exception;

        return Value;
    }

    public readonly Exception? GetException()
    {
        if (Value < 0)
            return new Win32Exception(Value);

        return null;
    }

    public static HRESULT RunWithRetries(Func<HRESULT> func, HRESULT retryableValue, int maxRetries = int.MaxValue, int retryWaitMs = 0, bool throwOnError = true) => RunWithRetries(func, [retryableValue], maxRetries, retryWaitMs, throwOnError);
    public static HRESULT RunWithRetries(Func<HRESULT> func, IEnumerable<HRESULT>? retryableValues = null, int maxRetries = int.MaxValue, int retryWaitMs = 0, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(func);

        var count = 0;
        HRESULT hr;
        do
        {
            hr = func().ThrowOnErrorExcept(retryableValues, throwOnError);
            if (hr.IsSuccess)
                return hr;

            if (retryWaitMs > 0)
            {
                Thread.Sleep(retryWaitMs);
            }
            count++;
        }
        while (count < maxRetries);
        return hr;
    }

    public override readonly bool Equals(object? obj) => Value.Equals(obj);
    public override readonly int GetHashCode() => Value.GetHashCode();
    public readonly bool Equals(HRESULT other) => Value.Equals(other.Value);

    public override readonly string ToString() => ToString(null, null);
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        switch (format?.ToLowerInvariant())
        {
            case "i":
                return Value.ToString();

            case "u":
                return UValue.ToString();

            case "n":
                if (!_names.TryGetValue(Value, out var text))
                {
                    var value = Value;
                    text = typeof(Constants).GetFields(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(f => f.FieldType == typeof(HRESULT) && ((int)(HRESULT)f.GetValue(null)!) == value)?.Name;
                    _names[Value] = text;
                }
                return text ?? string.Empty;

            case "x":
                return "0x" + Value.ToString("X8");

            default: // f
                var name = ToString("n", formatProvider);
                if (!string.IsNullOrEmpty(name))
                    return name + " (0x" + Value.ToString("X8") + ")";

                return "0x" + Value.ToString("X8");
        }
    }

    public static HRESULT FromWin32(int error)
    {
        if (error < 0)
            return error;

        const int FACILITY_WIN32 = 7;
        return (uint)(error & 0x0000FFFF) | (FACILITY_WIN32 << 16) | 0x80000000;
    }

    public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;
    public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

    public static implicit operator HRESULT(int value) => new(value);
    public static implicit operator HRESULT(uint result) => new(result);

    public static explicit operator uint(HRESULT hr) => hr.UValue;
    public static explicit operator int(HRESULT hr) => hr.Value;
}
