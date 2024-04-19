namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrdeinterlacetech
public enum VMRDeinterlaceTech
{
    DeinterlaceTech_Unknown = 0,
    DeinterlaceTech_BOBLineReplicate = 1,
    DeinterlaceTech_BOBVerticalStretch = 2,
    DeinterlaceTech_MedianFiltering = 4,
    DeinterlaceTech_EdgeFiltering = 16,
    DeinterlaceTech_FieldAdaptive = 32,
    DeinterlaceTech_PixelAdaptive = 64,
    DeinterlaceTech_MotionVectorSteered = 128,
}
