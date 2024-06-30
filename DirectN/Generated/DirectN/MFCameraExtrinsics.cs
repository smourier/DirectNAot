#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfcameraextrinsics
public partial struct MFCameraExtrinsics
{
    public uint TransformCount;
    public InlineArrayMFCameraExtrinsic_CalibratedTransform_1 CalibratedTransforms; // variable-length array placeholder
}
