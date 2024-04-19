namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_videoprimaries
public enum DXVA2_VideoPrimaries
{
    DXVA2_VideoPrimariesMask = 31,
    DXVA2_VideoPrimaries_Unknown = 0,
    DXVA2_VideoPrimaries_reserved = 1,
    DXVA2_VideoPrimaries_BT709 = 2,
    DXVA2_VideoPrimaries_BT470_2_SysM = 3,
    DXVA2_VideoPrimaries_BT470_2_SysBG = 4,
    DXVA2_VideoPrimaries_SMPTE170M = 5,
    DXVA2_VideoPrimaries_SMPTE240M = 6,
    DXVA2_VideoPrimaries_EBU3213 = 7,
    DXVA2_VideoPrimaries_SMPTE_C = 8,
}
