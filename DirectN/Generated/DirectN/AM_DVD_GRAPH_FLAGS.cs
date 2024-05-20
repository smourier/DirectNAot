#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-am_dvd_graph_flags
public enum AM_DVD_GRAPH_FLAGS
{
    AM_DVD_HWDEC_PREFER = 1,
    AM_DVD_HWDEC_ONLY = 2,
    AM_DVD_SWDEC_PREFER = 4,
    AM_DVD_SWDEC_ONLY = 8,
    AM_DVD_NOVPE = 256,
    AM_DVD_DO_NOT_CLEAR = 512,
    AM_DVD_VMR9_ONLY = 2048,
    AM_DVD_EVR_ONLY = 4096,
    AM_DVD_EVR_QOS = 8192,
    AM_DVD_ADAPT_GRAPH = 16384,
    AM_DVD_MASK = 65535,
}
