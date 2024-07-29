#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1commandsink3
[GeneratedComInterface, Guid("18079135-4cf3-4868-bc8e-06067e6d242d")]
public partial interface ID2D1CommandSink3 : ID2D1CommandSink2
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink3-drawspritebatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawSpriteBatch(ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
}
