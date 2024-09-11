#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext3
[GeneratedComInterface, Guid("235a7496-8351-414c-bcd4-6672ab2d8e00")]
public partial interface ID2D1DeviceContext3 : ID2D1DeviceContext2
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext3-createspritebatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSpriteBatch([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SpriteBatch>))] out ID2D1SpriteBatch spriteBatch);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext3-drawspritebatch(id2d1spritebatch_id2d1bitmap_d2d1_bitmap_interpolation_mode_d2d1_sprite_options)
    [PreserveSig]
    void DrawSpriteBatch([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SpriteBatch>))] ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
}
