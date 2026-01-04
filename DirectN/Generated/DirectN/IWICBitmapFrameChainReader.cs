#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0c599495-a120-4222-9130-a8c29410bd0b")]
public partial interface IWICBitmapFrameChainReader
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChainedFrameCount(WICBitmapChainType chainType, out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChainedFrame(WICBitmapChainType chainType, uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapFrameDecode>))] out IWICBitmapFrameDecode ppIBitmapFrame);
}
