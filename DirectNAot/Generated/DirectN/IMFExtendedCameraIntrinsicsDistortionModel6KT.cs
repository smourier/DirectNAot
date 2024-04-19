namespace DirectN;

[GeneratedComInterface, Guid("74c2653b-5f55-4eb1-9f0f-18b8f68b7d3d")]
public partial interface IMFExtendedCameraIntrinsicsDistortionModel6KT
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDistortionModel(out MFCameraIntrinsic_DistortionModel6KT pDistortionModel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDistortionModel(in MFCameraIntrinsic_DistortionModel6KT pDistortionModel);
}
