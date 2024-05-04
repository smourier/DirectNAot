#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudiometadataitemsbuffer
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("42640a16-e1bd-42d9-9ff6-031ab71a2dba")]
public partial interface ISpatialAudioMetadataItemsBuffer
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataitemsbuffer-attachtobuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachToBuffer(nint /* byte array */ buffer, uint bufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataitemsbuffer-attachtopopulatedbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachToPopulatedBuffer(nint /* byte array */ buffer, uint bufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataitemsbuffer-detachbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DetachBuffer();
}
