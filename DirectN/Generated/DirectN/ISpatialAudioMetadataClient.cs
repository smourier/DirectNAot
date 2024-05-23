#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudiometadataclient
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("777d4a3b-f6ff-4a26-85dc-68d7cdeda1d4")]
public partial interface ISpatialAudioMetadataClient
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataclient-activatespatialaudiometadataitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioMetadataItems(ushort maxItemCount, ushort frameCount, nint /* optional ISpatialAudioMetadataItemsBuffer* */ metadataItemsBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioMetadataItems>))] out ISpatialAudioMetadataItems metadataItems);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataclient-getspatialaudiometadataitemsbufferlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpatialAudioMetadataItemsBufferLength(ushort maxItemCount, out uint bufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataclient-activatespatialaudiometadatawriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioMetadataWriter(SpatialAudioMetadataWriterOverflowMode overflowMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioMetadataWriter>))] out ISpatialAudioMetadataWriter metadataWriter);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataclient-activatespatialaudiometadatacopier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioMetadataCopier([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioMetadataCopier>))] out ISpatialAudioMetadataCopier metadataCopier);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadataclient-activatespatialaudiometadatareader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioMetadataReader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioMetadataReader>))] out ISpatialAudioMetadataReader metadataReader);
}
