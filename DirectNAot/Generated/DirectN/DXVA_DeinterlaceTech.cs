namespace DirectN;

public enum DXVA_DeinterlaceTech
{
    DXVA_DeinterlaceTech_Unknown = 0,
    DXVA_DeinterlaceTech_BOBLineReplicate = 1,
    DXVA_DeinterlaceTech_BOBVerticalStretch = 2,
    DXVA_DeinterlaceTech_BOBVerticalStretch4Tap = 256,
    DXVA_DeinterlaceTech_MedianFiltering = 4,
    DXVA_DeinterlaceTech_EdgeFiltering = 16,
    DXVA_DeinterlaceTech_FieldAdaptive = 32,
    DXVA_DeinterlaceTech_PixelAdaptive = 64,
    DXVA_DeinterlaceTech_MotionVectorSteered = 128,
}
