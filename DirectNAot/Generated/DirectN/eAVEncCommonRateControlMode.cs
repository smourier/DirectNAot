namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavenccommonratecontrolmode
public enum eAVEncCommonRateControlMode
{
    eAVEncCommonRateControlMode_CBR = 0,
    eAVEncCommonRateControlMode_PeakConstrainedVBR = 1,
    eAVEncCommonRateControlMode_UnconstrainedVBR = 2,
    eAVEncCommonRateControlMode_Quality = 3,
    eAVEncCommonRateControlMode_LowDelayVBR = 4,
    eAVEncCommonRateControlMode_GlobalVBR = 5,
    eAVEncCommonRateControlMode_GlobalLowDelayVBR = 6,
}
