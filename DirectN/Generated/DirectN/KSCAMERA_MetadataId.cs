#nullable enable
namespace DirectN;

public enum KSCAMERA_MetadataId
{
    MetadataId_Standard_Start = 1,
    MetadataId_PhotoConfirmation = 1,
    MetadataId_UsbVideoHeader = 2,
    MetadataId_CaptureStats = 3,
    MetadataId_CameraExtrinsics = 4,
    MetadataId_CameraIntrinsics = 5,
    MetadataId_FrameIllumination = 6,
    MetadataId_DigitalWindow = 7,
    MetadataId_BackgroundSegmentationMask = 8,
    MetadataId_Standard_End = 8,
    MetadataId_Custom_Start = int.MinValue,
}
