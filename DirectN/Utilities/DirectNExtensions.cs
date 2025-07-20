namespace DirectN;

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

    public static float Clamp(this float value, float min, float max = float.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static double Clamp(this double value, double min, double max = double.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static byte Clamp(this byte value, byte min, byte max = byte.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static int Clamp(this int value, int min, int max = int.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static uint Clamp(this uint value, uint min, uint max = uint.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static long Clamp(this long value, long min, long max = long.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

    public static ulong Clamp(this ulong value, ulong min, ulong max = ulong.MaxValue)
    {
        if (max < min) (min, max) = (max, min);
        return value < min ? min : value > max ? max : value;
    }

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

    public static float PixelToHiMetric(this float value, uint dpi) => D2D_SIZE_F.HIMETRIC_PER_INCH * value / dpi;
    public static double PixelToHiMetric(this double value, uint dpi) => D2D_SIZE_F.HIMETRIC_PER_INCH * value / dpi;
    public static int PixelToHiMetric(this int value, uint dpi) => (int)(D2D_SIZE_F.HIMETRIC_PER_INCH * value / dpi);
    public static uint PixelToHiMetric(this uint value, uint dpi) => (uint)(D2D_SIZE_F.HIMETRIC_PER_INCH * value / dpi);
    public static float HiMetricToPixel(this float value, uint dpi) => value * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH;
    public static double HiMetricToPixel(this double value, uint dpi) => value * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH;
    public static int HiMetricToPixel(this int value, uint dpi) => (int)(value * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH);
    public static uint HiMetricToPixel(this uint value, uint dpi) => (uint)(value * dpi / D2D_SIZE_F.HIMETRIC_PER_INCH);

    public static int PixelsToDips(int pixels, uint dpi) => (int)(pixels * Constants.USER_DEFAULT_SCREEN_DPI / dpi);
    public static int DipsToPixels(int dips, uint dpi) => (int)(dips * dpi / Constants.USER_DEFAULT_SCREEN_DPI);
    public static uint PixelsToDips(uint pixels, uint dpi) => pixels * Constants.USER_DEFAULT_SCREEN_DPI / dpi;
    public static uint DipsToPixels(uint dips, uint dpi) => dips * dpi / Constants.USER_DEFAULT_SCREEN_DPI;
    public static float PixelsToDips(float pixels, uint dpi) => pixels * Constants.USER_DEFAULT_SCREEN_DPI / dpi;
    public static float DipsToPixels(float dips, uint dpi) => dips * dpi / Constants.USER_DEFAULT_SCREEN_DPI;
    public static double PixelsToDips(double pixels, uint dpi) => pixels * Constants.USER_DEFAULT_SCREEN_DPI / dpi;
    public static double DipsToPixels(double dips, uint dpi) => dips * dpi / Constants.USER_DEFAULT_SCREEN_DPI;

    public static uint DpiScale(uint value, uint oldDpi, uint newDpi) => (uint)DpiScale((float)value, oldDpi, newDpi);
    public static int DpiScale(int value, uint oldDpi, uint newDpi) => (int)DpiScale((float)value, oldDpi, newDpi);
    public static float DpiScale(float value, uint oldDpi, uint newDpi) => value * newDpi / oldDpi;
    public static double DpiScale(double value, uint oldDpi, uint newDpi) => value * newDpi / oldDpi;
    public static Vector2 DpiScale(Vector2 value, uint oldDpi, uint newDpi) => new(DpiScale(value.X, oldDpi, newDpi), DpiScale(value.Y, oldDpi, newDpi));
    public static Vector3 DpiScale(Vector3 value, uint oldDpi, uint newDpi) => new(DpiScale(value.X, oldDpi, newDpi), DpiScale(value.Y, oldDpi, newDpi), DpiScale(value.Z, oldDpi, newDpi));
    public static D2D_SIZE_F DpiScale(D2D_SIZE_F value, uint oldDpi, uint newDpi) => new(DpiScale(value.width, oldDpi, newDpi), DpiScale(value.height, oldDpi, newDpi));

    public static D2D_RECT_F DpiScale(D2D_RECT_F value, uint oldDpi, uint newDpi) => new(
        DpiScale(value.left, oldDpi, newDpi),
        DpiScale(value.top, oldDpi, newDpi),
        DpiScale(value.right, oldDpi, newDpi),
        DpiScale(value.bottom, oldDpi, newDpi));

    public static D2D_RECT_F DpiScaleThickness(D2D_RECT_F value, uint oldDpi, uint newDpi) => D2D_RECT_F.Thickness(
        DpiScale(value.left, oldDpi, newDpi),
        DpiScale(value.top, oldDpi, newDpi),
        DpiScale(value.right, oldDpi, newDpi),
        DpiScale(value.bottom, oldDpi, newDpi));

    public static D2D_RECT_F DpiScaleSized(D2D_RECT_F value, uint oldDpi, uint newDpi) => D2D_RECT_F.Sized(
        DpiScale(value.left, oldDpi, newDpi),
        DpiScale(value.top, oldDpi, newDpi),
        DpiScale(value.Width, oldDpi, newDpi),
        DpiScale(value.Height, oldDpi, newDpi));

    // https://blogs.msdn.microsoft.com/text/2009/12/11/wpf-text-measurement-units/
    public static float PointsToDips(this float pt) => Constants.USER_DEFAULT_SCREEN_DPI / (72 * pt);
    public static float DipsToPoints(this float dip) => 72 / (Constants.USER_DEFAULT_SCREEN_DPI * dip);
    public static float PointsToTwips(this float pt) => pt * 20;
    public static float TwipsToPoints(this float twips) => twips / 20;

    public static double PointsToDips(this double pt) => Constants.USER_DEFAULT_SCREEN_DPI / (72 * pt);
    public static double DipsToPoints(this double dip) => 72 / (Constants.USER_DEFAULT_SCREEN_DPI * dip);
    public static double PointsToTwips(this double pt) => pt * 20;
    public static double TwipsToPoints(this double twips) => twips / 20;

    public static int PointsToDips(this int pt) => (int)(Constants.USER_DEFAULT_SCREEN_DPI / (72.0 * pt));
    public static int DipsToPoints(this int dip) => (int)(72 / ((double)Constants.USER_DEFAULT_SCREEN_DPI * dip));
    public static int PointsToTwips(this int pt) => (int)(pt * 20.0);
    public static int TwipsToPoints(this int twips) => (int)(twips / 20.0);

    public static uint PointsToDips(this uint pt) => (uint)(Constants.USER_DEFAULT_SCREEN_DPI / (72.0 * pt));
    public static uint DipsToPoints(this uint dip) => (uint)(72 / ((double)Constants.USER_DEFAULT_SCREEN_DPI * dip));
    public static uint PointsToTwips(this uint pt) => (uint)(pt * 20.0);
    public static uint TwipsToPoints(this uint twips) => (uint)(twips / 20.0);

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
