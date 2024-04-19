namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mfframesourcetypes
public enum MFFrameSourceTypes
{
    MFFrameSourceTypes_Color = 1,
    MFFrameSourceTypes_Infrared = 2,
    MFFrameSourceTypes_Depth = 4,
    MFFrameSourceTypes_Image = 8,
    MFFrameSourceTypes_Custom = 128,
}
