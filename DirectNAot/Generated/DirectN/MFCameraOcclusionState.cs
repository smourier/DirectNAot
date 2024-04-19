namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfcameraocclusionstate
public enum MFCameraOcclusionState
{
    MFCameraOcclusionState_Open = 0,
    MFCameraOcclusionState_OccludedByLid = 1,
    MFCameraOcclusionState_OccludedByCameraHardware = 2,
}
