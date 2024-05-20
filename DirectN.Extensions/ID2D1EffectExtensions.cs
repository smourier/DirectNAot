namespace DirectN;

[SupportedOSPlatform("windows8.0")]
public static class ID2D1EffectExtensions
{
    public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Image> image, int index = 0, bool invalidate = false) => SetInput(effect?.Object!, image?.Object!, index, invalidate);
    public static void SetInput(this ID2D1Effect effect, ID2D1Image image, int index = 0, bool invalidate = false)
    {
        ArgumentNullException.ThrowIfNull(effect);
        ArgumentNullException.ThrowIfNull(image);
        effect.SetInput((uint)index, image, invalidate);
    }

    public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Effect>? input = null, int index = 0, bool invalidate = false) => SetInput(effect?.Object!, input?.Object!, index, invalidate);
    public static void SetInput(this ID2D1Effect effect, ID2D1Effect? input = null, int index = 0, bool invalidate = false)
    {
        ArgumentNullException.ThrowIfNull(effect);
        ArgumentNullException.ThrowIfNull(input);
        using var output = input.GetOutput();
        effect.SetInput((uint)index, output.Object, invalidate);
    }

    public static IComObject<ID2D1Image> GetInput(this IComObject<ID2D1Effect> effect, uint index) => GetInput(effect?.Object!, index);
    public static IComObject<ID2D1Image> GetInput(this ID2D1Effect effect, uint index)
    {
        ArgumentNullException.ThrowIfNull(effect);
        effect.GetInput(index, out var image);
        return new ComObject<ID2D1Image>(image);
    }

    public static uint GetInputCount(this IComObject<ID2D1Effect> effect) => GetInputCount(effect?.Object!);
    public static uint GetInputCount(this ID2D1Effect effect)
    {
        ArgumentNullException.ThrowIfNull(effect);
        return effect.GetInputCount();
    }

    public static void SetInputCount(this IComObject<ID2D1Effect> effect, uint count) => SetInputCount(effect?.Object!, count);
    public static void SetInputCount(this ID2D1Effect effect, uint count)
    {
        ArgumentNullException.ThrowIfNull(effect);
        effect.SetInputCount(count).ThrowOnError();
    }

    public static IComObject<ID2D1Image> GetOutput(this IComObject<ID2D1Effect> effect) => GetOutput(effect?.Object!);
    public static IComObject<ID2D1Image> GetOutput(this ID2D1Effect effect)
    {
        ArgumentNullException.ThrowIfNull(effect);
        effect.GetOutput(out var image);
        return new ComObject<ID2D1Image>(image);
    }
}
