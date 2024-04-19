namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudioobjectformetadataitems
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("ddea49ff-3bc0-4377-8aad-9fbcfd808566")]
public partial interface ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudioobjectformetadataitems-getspatialaudiometadataitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpatialAudioMetadataItems(out ISpatialAudioMetadataItems metadataItems);
}
