#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3373fdf-6d39-4e5f-8e79-bf40c0b7ed77")]
public partial interface IWICBitmapSourceTransform2 : IWICBitmapSourceTransform
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorContextsForPixelFormat(in Guid pPixelFormat, uint cCount, [In][MarshalUsing(CountElementName = nameof(cCount))] IWICColorContext[] ppIColorContexts, out uint pcActualCount);
}
