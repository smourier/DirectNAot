﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_mediaitem_cleared_event
public partial struct MFP_MEDIAITEM_CLEARED_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
}
