#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudiometadatacopier
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("d224b233-e251-4fd0-9ca2-d5ecf9a68404")]
public partial interface ISpatialAudioMetadataCopier
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatacopier-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(ISpatialAudioMetadataItems metadataItems);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatacopier-copymetadataforframes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyMetadataForFrames(ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, ISpatialAudioMetadataItems dstMetadataItems, out ushort itemsCopied);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatacopier-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
