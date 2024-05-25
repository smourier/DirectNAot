﻿namespace DirectN;

public static class DirectNExtensions
{
    public static bool IsValid(this float value) => !float.IsNaN(value);
    public static bool IsInvalid(this float value) => float.IsNaN(value);
    public static bool IsSet(this float value) => IsValid(value) && !float.IsInfinity(value);
    public static bool IsNotSet(this float value) => IsInvalid(value) || float.IsInfinity(value);
    public static bool IsMinOrMax(this float value) => value == float.MaxValue || value == float.MinValue;
    public static bool IsMax(this float value) => value == float.MaxValue;
    public static bool IsMin(this float value) => value == float.MinValue;
    public static int SignedLOWORD(this nint value) => SignedLOWORD((int)(long)value);
    public static int SignedLOWORD(this nuint value) => SignedLOWORD((int)(long)value);
    public static int SignedLOWORD(this int value) => (short)(value & 0xffff);
    public static int SignedLOWORD(this uint value) => (short)(value & 0xffff);
    public static int SignedHIWORD(this nint value) => SignedHIWORD((int)(long)value);
    public static int SignedHIWORD(this nuint value) => SignedHIWORD((int)(long)value);
    public static int SignedHIWORD(this int value) => (short)((value >> 0x10) & 0xffff);
    public static int SignedHIWORD(this uint value) => (short)((value >> 0x10) & 0xffff);
    public static int HIWORD(this int value) => (value >> 0x10) & 0xffff;
    public static uint HIWORD(this uint value) => (value >> 0x10) & 0xffff;
    public static int HIWORD(this nint value) => HIWORD((int)(long)value);
    public static uint HIWORD(this nuint value) => HIWORD((uint)(ulong)value);
    public static int LOWORD(this int value) => value & 0xffff;
    public static uint LOWORD(this uint value) => value & 0xffff;
    public static uint LOWORD(this nuint value) => LOWORD((uint)(ulong)value);
    public static int LOWORD(this nint value) => LOWORD((int)(long)value);
    public static float ToZero(this float value) => float.IsNaN(value) ? 0 : value;
    public static int GET_X_LPARAM(this nint lParam) => LOWORD(lParam);
    public static int GET_Y_LPARAM(this nint lParam) => HIWORD(lParam);
    public static int GET_X_LPARAM(this nuint lParam) => (int)LOWORD(lParam);
    public static int GET_Y_LPARAM(this nuint lParam) => (int)HIWORD(lParam);

    public static float NextFloat(this Random random) => (float)(random?.NextDouble() ?? 0f);
    public static byte NextByte(this Random random, byte minValue = 0, byte maxValue = 255) => (byte)(random?.Next(minValue, maxValue) ?? 0);

    public static bool IsValid(this Vector2 value) => value.X.IsValid() && value.Y.IsValid();
    public static bool IsInvalid(this Vector2 value) => value.X.IsInvalid() || value.Y.IsInvalid();
    public static bool IsSet(this Vector2 value) => value.X.IsSet() && value.Y.IsSet();
    public static bool IsNotSet(this Vector2 value) => value.X.IsNotSet() || value.Y.IsNotSet();
    public static bool IsNotZero(this Vector2 value) => IsValid(value) && value.X != 0 && value.Y != 0;
    public static bool IsZero(this Vector2 value) => IsValid(value) && value.X == 0 && value.Y == 0;

    public static float Ceiling(this float value) => (float)Math.Ceiling(value);
    public static int CeilingI(this float value) => Math.Ceiling(value).ToInt32();
    public static uint CeilingU(this float value) => Math.Ceiling(value).ToUInt32();
    public static float Floor(this float value) => (float)Math.Floor(value);
    public static int FloorI(this float value) => Math.Floor(value).ToInt32();
    public static uint FloorU(this float value) => Math.Floor(value).ToUInt32();
    public static float Round(this float value) => (float)Math.Round(value);
    public static int RoundI(this float value) => Math.Round(value).ToInt32();
    public static uint RoundU(this float value) => Math.Round(value).ToUInt32();

    public static double Ceiling(this double value) => Math.Ceiling(value);
    public static int CeilingI(this double value) => Math.Ceiling(value).ToInt32();
    public static uint CeilingU(this double value) => Math.Ceiling(value).ToUInt32();
    public static double Floor(this double value) => Math.Floor(value);
    public static int FloorI(this double value) => Math.Floor(value).ToInt32();
    public static uint FloorU(this double value) => Math.Floor(value).ToUInt32();
    public static double Round(this double value) => Math.Round(value);
    public static int RoundI(this double value) => Math.Round(value).ToInt32();
    public static uint RoundU(this double value) => Math.Round(value).ToUInt32();

    public static float Clamp(this float value, float min, float max = float.MaxValue) => value < min ? min : value > max ? max : value;
    public static double Clamp(this double value, double min, double max = double.MaxValue) => value < min ? min : value > max ? max : value;
    public static byte Clamp(this byte value, byte min, byte max = byte.MaxValue) => value < min ? min : value > max ? max : value;
    public static int Clamp(this int value, int min, int max = int.MaxValue) => value < min ? min : value > max ? max : value;
    public static uint Clamp(this uint value, uint min, uint max = uint.MaxValue) => value < min ? min : value > max ? max : value;
    public static long Clamp(this long value, long min, long max = long.MaxValue) => value < min ? min : value > max ? max : value;
    public static ulong Clamp(this ulong value, ulong min, ulong max = ulong.MaxValue) => value < min ? min : value > max ? max : value;

    public static float ClampMinMax(this float value)
    {
        if (float.IsPositiveInfinity(value))
            return float.MaxValue;

        if (float.IsNegativeInfinity(value))
            return float.MinValue;

        return value;
    }

    public static double ClampMinMax(this double value)
    {
        if (double.IsPositiveInfinity(value))
            return double.MaxValue;

        if (double.IsNegativeInfinity(value))
            return double.MinValue;

        return value;
    }

    public static uint ToUInt32(this float value)
    {
        if (float.IsNaN(value))
            throw new OverflowException();

        if (value <= 0)
            return 0;

        if (value >= uint.MaxValue)
            return uint.MaxValue;

        return (uint)value;
    }

    public static int ToInt32(this float value)
    {
        if (float.IsNaN(value))
            throw new OverflowException();

        if (value <= int.MinValue)
            return int.MinValue;

        if (value >= int.MaxValue)
            return int.MaxValue;

        return (int)value;
    }

    public static uint ToUInt32(this double value)
    {
        if (double.IsNaN(value))
            throw new OverflowException();

        if (value <= 0)
            return 0;

        if (value >= uint.MaxValue)
            return uint.MaxValue;

        return (uint)value;
    }

    public static int ToInt32(this double value)
    {
        if (double.IsNaN(value))
            throw new OverflowException();

        if (value <= int.MinValue)
            return int.MinValue;

        if (value >= int.MaxValue)
            return int.MaxValue;

        return (int)value;
    }

    public static void CopyFrom<T>(string? str, Span<char> chars, int length)
    {
        for (var i = 0; i < length; i++)
        {
            if (str != null && i < str.Length)
            {
                chars[i] = str[i];
            }
            else
            {
                chars[i] = '\0';
            }
        }
    }
}
