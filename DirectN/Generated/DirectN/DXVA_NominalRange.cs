#nullable enable
namespace DirectN;

public enum DXVA_NominalRange
{
    DXVA_NominalRangeShift = 12,
    DXVA_NominalRangeMask = 28672,
    DXVA_NominalRange_Unknown = 0,
    DXVA_NominalRange_Normal = 1,
    DXVA_NominalRange_Wide = 2,
    DXVA_NominalRange_0_255 = 1,
    DXVA_NominalRange_16_235 = 2,
    DXVA_NominalRange_48_208 = 3,
}
