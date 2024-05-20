namespace DirectN.Extensions;

public static class IWICColorContextExtensions
{
    public static uint GetExifColorSpace(this IComObject<IWICColorContext> bitmap) => GetExifColorSpace(bitmap?.Object!);
    public static uint GetExifColorSpace(this IWICColorContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetExifColorSpace(out var space).ThrowOnError();
        return space;
    }
}
