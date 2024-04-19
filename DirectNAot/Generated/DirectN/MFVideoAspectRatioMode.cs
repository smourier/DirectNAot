namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/ne-evr-mfvideoaspectratiomode
public enum MFVideoAspectRatioMode
{
    MFVideoARMode_None = 0,
    MFVideoARMode_PreservePicture = 1,
    MFVideoARMode_PreservePixel = 2,
    MFVideoARMode_NonLinearStretch = 4,
    MFVideoARMode_Mask = 7,
}
