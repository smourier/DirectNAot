namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mfvideo3dformat
public enum MFVideo3DFormat
{
    MFVideo3DSampleFormat_BaseView = 0,
    MFVideo3DSampleFormat_MultiView = 1,
    MFVideo3DSampleFormat_Packed_LeftRight = 2,
    MFVideo3DSampleFormat_Packed_TopBottom = 3,
}
