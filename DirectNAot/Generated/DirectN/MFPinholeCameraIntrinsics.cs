#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfpinholecameraintrinsics
[StructLayout(LayoutKind.Sequential)]
public partial struct MFPinholeCameraIntrinsics
{
    public uint IntrinsicModelCount;
    public InlineArrayMFPinholeCameraIntrinsic_IntrinsicModel1 IntrinsicModels; // variable-length array placeholder
}
