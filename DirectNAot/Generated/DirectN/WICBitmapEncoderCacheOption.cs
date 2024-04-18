namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmapencodercacheoption
public enum WICBitmapEncoderCacheOption
{
    WICBitmapEncoderCacheInMemory = 0,
    WICBitmapEncoderCacheTempFile = 1,
    WICBitmapEncoderNoCache = 2,
}
