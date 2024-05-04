#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrpresentationflags
public enum VMRPresentationFlags
{
    VMRSample_SyncPoint = 1,
    VMRSample_Preroll = 2,
    VMRSample_Discontinuity = 4,
    VMRSample_TimeValid = 8,
    VMRSample_SrcDstRectsValid = 16,
}
