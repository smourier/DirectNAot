#nullable enable
namespace DirectN;

public enum DXVA_VideoPrimaries
{
    DXVA_VideoPrimariesShift = 22,
    DXVA_VideoPrimariesMask = 130023424,
    DXVA_VideoPrimaries_Unknown = 0,
    DXVA_VideoPrimaries_reserved = 1,
    DXVA_VideoPrimaries_BT709 = 2,
    DXVA_VideoPrimaries_BT470_2_SysM = 3,
    DXVA_VideoPrimaries_BT470_2_SysBG = 4,
    DXVA_VideoPrimaries_SMPTE170M = 5,
    DXVA_VideoPrimaries_SMPTE240M = 6,
    DXVA_VideoPrimaries_EBU3213 = 7,
    DXVA_VideoPrimaries_SMPTE_C = 8,
}
