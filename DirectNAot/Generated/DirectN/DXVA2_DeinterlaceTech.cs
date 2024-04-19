namespace DirectN;

public enum DXVA2_DeinterlaceTech
{
    DXVA2_DeinterlaceTech_Unknown = 0,
    DXVA2_DeinterlaceTech_BOBLineReplicate = 1,
    DXVA2_DeinterlaceTech_BOBVerticalStretch = 2,
    DXVA2_DeinterlaceTech_BOBVerticalStretch4Tap = 4,
    DXVA2_DeinterlaceTech_MedianFiltering = 8,
    DXVA2_DeinterlaceTech_EdgeFiltering = 16,
    DXVA2_DeinterlaceTech_FieldAdaptive = 32,
    DXVA2_DeinterlaceTech_PixelAdaptive = 64,
    DXVA2_DeinterlaceTech_MotionVectorSteered = 128,
    DXVA2_DeinterlaceTech_InverseTelecine = 256,
    DXVA2_DeinterlaceTech_Mask = 511,
}
