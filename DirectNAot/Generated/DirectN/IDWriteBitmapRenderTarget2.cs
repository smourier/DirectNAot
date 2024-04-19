namespace DirectN;

[GeneratedComInterface, Guid("c553a742-fc01-44da-a66e-b8b9ed6c3995")]
public partial interface IDWriteBitmapRenderTarget2 : IDWriteBitmapRenderTarget1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBitmapData(out DWRITE_BITMAP_DATA_BGRA32 bitmapData);
}
