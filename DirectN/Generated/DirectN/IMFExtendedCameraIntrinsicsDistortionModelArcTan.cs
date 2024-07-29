#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("812d5f95-b572-45dc-bafc-ae24199ddda8")]
public partial interface IMFExtendedCameraIntrinsicsDistortionModelArcTan
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDistortionModel(out MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDistortionModel(in MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
}
