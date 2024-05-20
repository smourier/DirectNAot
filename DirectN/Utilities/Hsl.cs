namespace DirectN;

public struct Hsl(float hue, float saturation, float brightness) : IEquatable<Hsl>
{
    public float Hue = hue;
    public float Saturation = saturation;
    public float Brightness = brightness;

    public readonly Hsl Complementary
    {
        get
        {
            var hue = Hue;
            hue += 0.5f;
            if (hue > 1f)
            {
                hue -= 1f;
            }
            return new Hsl(hue, Saturation, Brightness);
        }
    }

    public readonly Tuple<Hsl, Hsl> Triadic
    {
        get
        {
            var first = Hue;
            first += 1f / 3f;
            if (first > 1f)
            {
                first -= 1f;
            }

            var second = Hue;
            second += 2f / 3f;
            if (second > 1f)
            {
                second -= 1f;
            }
            return new Tuple<Hsl, Hsl>(new Hsl(first, Saturation, Brightness), new Hsl(second, Saturation, Brightness));
        }
    }

    public D3DCOLORVALUE ToD3DCOLORVALUE(float a = 1f)
    {
        float r;
        float g;
        float b;

        if (Brightness == 0f)
        {
            r = 0f;
            g = 0f;
            b = 0f;
        }
        else
        {
            if (Saturation == 0f)
            {
                r = Brightness;
                g = Brightness;
                b = Brightness;
            }
            else
            {
                float v2;
                if (Brightness < 0.5f)
                {
                    v2 = Brightness * (1f + Saturation);
                }
                else
                {
                    v2 = (Brightness + Saturation) - (Saturation * Brightness);
                }

                var v1 = 2 * Brightness - v2;
                r = RgbFromHue(Hue + 1f / 3f, v1, v2);
                g = RgbFromHue(Hue, v1, v2);
                b = RgbFromHue(Hue - 1f / 3f, v1, v2);
            }
        }
        return new D3DCOLORVALUE(a, r, g, b);
    }

    private static float RgbFromHue(float h, float v1, float v2)
    {
        if (h < 0f)
        {
            h += 1f;
        }
        else if (h > 1f)
        {
            h -= 1f;
        }

        float color;
        if (6f * h < 1f)
        {
            color = v1 + (v2 - v1) * h * 6f;
        }
        else if (2f * h < 1f)
        {
            color = v2;
        }
        else if (3f * h < 2f)
        {
            color = (v1 + (v2 - v1) * ((2f / 3f) - h) * 6f);
        }
        else
        {
            color = v1;
        }
        return color;
    }

    public override readonly int GetHashCode() => Hue.GetHashCode() ^ Saturation.GetHashCode() ^ Brightness.GetHashCode();
    public override readonly bool Equals(object? other) => other is Hsl hsb && Equals(hsb);
    public readonly bool Equals(Hsl other) => Brightness == other.Brightness && Hue == other.Hue && Saturation == other.Saturation;
    public override readonly string ToString() => "H:" + Hue + " S:" + Saturation + " B:" + Brightness;

    public static Hsl From(D3DCOLORVALUE color) => new(Hsv.GetHue(color.r, color.g, color.b), GetSaturation(color.r, color.g, color.b), GetBrightness(color.r, color.g, color.b));

    public static float GetBrightness(float r, float g, float b)
    {
        var max = r;
        var min = r;
        if (g > max) max = g;
        if (b > max) max = b;
        if (g < min) min = g;
        if (b < min) min = b;
        return (max + min) / 2;
    }

    public static float GetSaturation(float r, float g, float b)
    {
        var max = r;
        var min = r;
        var s = 0f;

        if (g > max) max = g;
        if (b > max) max = b;
        if (g < min) min = g;
        if (b < min) min = b;

        if (max != min)
        {
            var l = (max + min) / 2;
            if (l <= .5f)
            {
                s = (max - min) / (max + min);
            }
            else
            {
                s = (max - min) / (2 - max - min);
            }
        }
        return s;
    }

    public static bool operator ==(Hsl x, Hsl y) => x.Equals(y);
    public static bool operator !=(Hsl x, Hsl y) => !x.Equals(y);
}
