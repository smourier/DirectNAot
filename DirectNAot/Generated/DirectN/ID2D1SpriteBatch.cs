namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1spritebatch
[GeneratedComInterface, Guid("4dc583bf-3a10-438a-8722-e9765224f1f1")]
public partial interface ID2D1SpriteBatch : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSprites(uint spriteCount, in D2D_RECT_F destinationRectangles, nint/* nint */ sourceRectangles, nint/* nint */ colors, nint/* nint */ transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSprites(uint startIndex, uint spriteCount, nint/* nint */ destinationRectangles, nint/* nint */ sourceRectangles, nint/* nint */ colors, nint/* nint */ transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSprites(uint startIndex, uint spriteCount, nint/* nint */ destinationRectangles, nint/* nint */ sourceRectangles, nint/* nint */ colors, nint/* nint */ transforms);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1spritebatch-getspritecount
    [PreserveSig]
    uint GetSpriteCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1spritebatch-clear
    [PreserveSig]
    void Clear();
}
