﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfcameraextrinsics
[StructLayout(LayoutKind.Sequential)]
public partial struct MFCameraExtrinsics
{
    public uint TransformCount;
    public InlineArrayMFCameraExtrinsic_CalibratedTransform1 CalibratedTransforms; // variable-length array placeholder
}
