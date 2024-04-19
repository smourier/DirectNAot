namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/ne-bdaiface-bda_drmpairingerror
public enum BDA_DrmPairingError
{
    BDA_DrmPairing_Succeeded = 0,
    BDA_DrmPairing_HardwareFailure = 1,
    BDA_DrmPairing_NeedRevocationData = 2,
    BDA_DrmPairing_NeedIndiv = 3,
    BDA_DrmPairing_Other = 4,
    BDA_DrmPairing_DrmInitFailed = 5,
    BDA_DrmPairing_DrmNotPaired = 6,
    BDA_DrmPairing_DrmRePairSoon = 7,
    BDA_DrmPairing_Aborted = 8,
    BDA_DrmPairing_NeedSDKUpdate = 9,
}
