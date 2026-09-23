namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class IDCompositionVisualExtensions
{
    public static void SetContent(this IComObject<IDCompositionVisual> visual, object? content) => SetContent(visual?.Object!, content);
    public static void SetContent(this IDCompositionVisual visual, object? content)
    {
        ArgumentNullException.ThrowIfNull(visual);
        if (content == null)
        {
            visual.SetContent(0).ThrowOnError();
            return;
        }

        ComObject.WithComInstance(content, unk => visual.SetContent(unk).ThrowOnError());
    }

    public static void AddVisual(this IComObject<IDCompositionVisual> visual, IComObject<IDCompositionVisual> child, bool insertAbove = true, IComObject<IDCompositionVisual>? referenceVisual = null) => AddVisual(visual?.Object!, child?.Object!, insertAbove, referenceVisual?.Object);
    public static void AddVisual(this IDCompositionVisual visual, IDCompositionVisual child, bool insertAbove = true, IDCompositionVisual? referenceVisual = null)
    {
        ArgumentNullException.ThrowIfNull(visual);
        ArgumentNullException.ThrowIfNull(child);
        visual.AddVisual(child, insertAbove, referenceVisual).ThrowOnError();
    }

    public static void RemoveVisual(this IComObject<IDCompositionVisual> visual, IComObject<IDCompositionVisual> child) => RemoveVisual(visual?.Object!, child?.Object!);
    public static void RemoveVisual(this IDCompositionVisual visual, IDCompositionVisual child)
    {
        ArgumentNullException.ThrowIfNull(visual);
        ArgumentNullException.ThrowIfNull(child);
        visual.RemoveVisual(child).ThrowOnError();
    }

    public static void RemoveAllVisuals(this IComObject<IDCompositionVisual> visual) => RemoveAllVisuals(visual?.Object!);
    public static void RemoveAllVisuals(this IDCompositionVisual visual)
    {
        ArgumentNullException.ThrowIfNull(visual);
        visual.RemoveAllVisuals().ThrowOnError();
    }
}
