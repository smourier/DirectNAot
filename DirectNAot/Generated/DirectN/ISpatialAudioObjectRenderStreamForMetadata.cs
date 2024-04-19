namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudioobjectrenderstreamformetadata
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("bbc9c907-48d5-4a2e-a0c7-f7f0d67c1fb1")]
public partial interface ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudioobjectrenderstreamformetadata-activatespatialaudioobjectformetadatacommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioObjectForMetadataCommands(AudioObjectType type, out ISpatialAudioObjectForMetadataCommands audioObject);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudioobjectrenderstreamformetadata-activatespatialaudioobjectformetadataitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioObjectForMetadataItems(AudioObjectType type, out ISpatialAudioObjectForMetadataItems audioObject);
}
