#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wiccomponentenumerateoptions
public enum WICComponentEnumerateOptions
{
    WICComponentEnumerateDefault = 0,
    WICComponentEnumerateRefresh = 1,
    WICComponentEnumerateDisabled = int.MinValue,
    WICComponentEnumerateUnsigned = 1073741824,
    WICComponentEnumerateBuiltInOnly = 536870912,
}
