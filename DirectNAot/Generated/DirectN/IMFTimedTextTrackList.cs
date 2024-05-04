#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtexttracklist
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("23ff334c-442c-445f-bccc-edc438aa11e2")]
public partial interface IMFTimedTextTrackList
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttracklist-getlength
    [PreserveSig]
    uint GetLength();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttracklist-gettrack
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrack(uint index, out IMFTimedTextTrack track);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttracklist-gettrackbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrackById(uint trackId, out IMFTimedTextTrack track);
}
