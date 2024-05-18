namespace DirectNAot.Extensions;

public sealed class WicBitmapFrameEncode : IDisposable
{
    public WicBitmapFrameEncode(IComObject<IWICBitmapFrameEncode> encode, IComObject<IPropertyBag2> bag)
    {
        ArgumentNullException.ThrowIfNull(encode);
        ArgumentNullException.ThrowIfNull(bag);
        Encode = encode;
        Bag = bag;
    }

    public WicBitmapFrameEncode(IWICBitmapFrameEncode encode, IPropertyBag2 bag)
    {
        ArgumentNullException.ThrowIfNull(encode);
        ArgumentNullException.ThrowIfNull(bag);
        Encode = new ComObject<IWICBitmapFrameEncode>(encode);
        Bag = new ComObject<IPropertyBag2>(bag);
    }

    public IComObject<IWICBitmapFrameEncode> Encode { get; }
    public IComObject<IPropertyBag2> Bag { get; }

    public void Dispose()
    {
        Encode.SafeDispose();
        Bag.SafeDispose();
    }
}
