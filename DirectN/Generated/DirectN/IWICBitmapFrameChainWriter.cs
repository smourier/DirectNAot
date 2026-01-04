#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("40d9ea28-4768-47b3-8c12-558a48e98e38")]
public partial interface IWICBitmapFrameChainWriter
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendFrameToChain(WICBitmapChainType chainType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapFrameEncode>))] out IWICBitmapFrameEncode ppIFrameEncode, ref IPropertyBag2 ppIEncoderOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportChainType(WICBitmapChainType chainType, out BOOL pfIsSupported);
}
