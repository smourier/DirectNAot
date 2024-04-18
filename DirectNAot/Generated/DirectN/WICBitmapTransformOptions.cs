namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmaptransformoptions
public enum WICBitmapTransformOptions
{
    WICBitmapTransformRotate0 = 0,
    WICBitmapTransformRotate90 = 1,
    WICBitmapTransformRotate180 = 2,
    WICBitmapTransformRotate270 = 3,
    WICBitmapTransformFlipHorizontal = 8,
    WICBitmapTransformFlipVertical = 16,
}
