namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class IDCompositionTargetExtensions
{
    public static void SetRoot(this IComObject<IDCompositionTarget> target, IComObject<IDCompositionVisual>? visual) => SetRoot(target?.Object!, visual?.Object);
    public static void SetRoot(this IDCompositionTarget target, IDCompositionVisual? visual)
    {
        ArgumentNullException.ThrowIfNull(target);
        target.SetRoot(visual).ThrowOnError();
    }
}
