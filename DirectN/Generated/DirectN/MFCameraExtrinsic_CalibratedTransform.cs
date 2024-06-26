﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfcameraextrinsic_calibratedtransform
public partial struct MFCameraExtrinsic_CalibratedTransform
{
    public Guid CalibrationId;
    public MF_FLOAT3 Position;
    public MF_QUATERNION Orientation;
}
