namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicddsalphamode
public enum WICDdsAlphaMode
{
    WICDdsAlphaModeUnknown = 0,
    WICDdsAlphaModeStraight = 1,
    WICDdsAlphaModePremultiplied = 2,
    WICDdsAlphaModeOpaque = 3,
    WICDdsAlphaModeCustom = 4,
}
