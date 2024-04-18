namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmapcreatecacheoption
public enum WICBitmapCreateCacheOption
{
    WICBitmapNoCache = 0,
    WICBitmapCacheOnDemand = 1,
    WICBitmapCacheOnLoad = 2,
}
