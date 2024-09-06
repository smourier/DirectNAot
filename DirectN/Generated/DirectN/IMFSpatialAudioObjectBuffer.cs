#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nn-mfspatialaudio-imfspatialaudioobjectbuffer
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("d396ec8c-605e-4249-978d-72ad1c312872")]
public partial interface IMFSpatialAudioObjectBuffer : IMFMediaBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudioobjectbuffer-setid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetID(uint u32ID);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudioobjectbuffer-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetID(out uint pu32ID);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudioobjectbuffer-settype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetType(AudioObjectType type);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudioobjectbuffer-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out AudioObjectType pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudioobjectbuffer-getmetadataitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioMetadataItems>))] out ISpatialAudioMetadataItems ppMetadataItems);
}
