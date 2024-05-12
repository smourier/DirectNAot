using DirectNAot.Extensions.Com;

namespace DirectNAot.Extensions;

public static class IWICColorTransformExtensions
{
    public static void Initialize(this IComObject<IWICColorTransform> transform, IComObject<IWICBitmapSource> source, IComObject<IWICColorContext> sourceColorContext, IComObject<IWICColorContext> destinationColorContext, Guid destinationPixelFormat) => Initialize(transform?.Object!, source?.Object!, sourceColorContext?.Object!, destinationColorContext?.Object!, destinationPixelFormat);
    public static void Initialize(this IWICColorTransform transform, IWICBitmapSource source, IWICColorContext sourceColorContext, IWICColorContext destinationColorContext, Guid destinationPixelFormat)
    {
        ArgumentNullException.ThrowIfNull(transform);
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(sourceColorContext);
        ArgumentNullException.ThrowIfNull(destinationColorContext);
        transform.Initialize(source, sourceColorContext, destinationColorContext, destinationPixelFormat).ThrowOnError();
    }
}
