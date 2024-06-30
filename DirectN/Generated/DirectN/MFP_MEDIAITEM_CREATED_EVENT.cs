#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_mediaitem_created_event
public partial struct MFP_MEDIAITEM_CREATED_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
    public nuint dwUserData;
}
