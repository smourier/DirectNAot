namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_nominalrange
public enum DXVA2_NominalRange
{
    DXVA2_NominalRangeMask = 7,
    DXVA2_NominalRange_Unknown = 0,
    DXVA2_NominalRange_Normal = 1,
    DXVA2_NominalRange_Wide = 2,
    DXVA2_NominalRange_0_255 = 1,
    DXVA2_NominalRange_16_235 = 2,
    DXVA2_NominalRange_48_208 = 3,
}
