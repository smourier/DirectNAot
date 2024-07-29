#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5c595e64-4630-4231-855a-12842f733245")]
public partial interface IMFExtendedCameraIntrinsicModel
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModel(out MFExtendedCameraIntrinsic_IntrinsicModel pIntrinsicModel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetModel(in MFExtendedCameraIntrinsic_IntrinsicModel pIntrinsicModel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDistortionModelType(out MFCameraIntrinsic_DistortionModelType pDistortionModelType);
}
