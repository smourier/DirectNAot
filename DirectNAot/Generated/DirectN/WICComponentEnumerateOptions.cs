namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wiccomponentenumerateoptions
public enum WICComponentEnumerateOptions
{
    WICComponentEnumerateDefault = 0,
    WICComponentEnumerateRefresh = 1,
    WICComponentEnumerateDisabled = -2147483648,
    WICComponentEnumerateUnsigned = 1073741824,
    WICComponentEnumerateBuiltInOnly = 536870912,
}
