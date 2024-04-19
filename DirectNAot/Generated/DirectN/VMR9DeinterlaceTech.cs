namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9deinterlacetech
public enum VMR9DeinterlaceTech
{
    DeinterlaceTech9_Unknown = 0,
    DeinterlaceTech9_BOBLineReplicate = 1,
    DeinterlaceTech9_BOBVerticalStretch = 2,
    DeinterlaceTech9_MedianFiltering = 4,
    DeinterlaceTech9_EdgeFiltering = 16,
    DeinterlaceTech9_FieldAdaptive = 32,
    DeinterlaceTech9_PixelAdaptive = 64,
    DeinterlaceTech9_MotionVectorSteered = 128,
}
