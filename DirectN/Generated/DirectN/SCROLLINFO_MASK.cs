#nullable enable
namespace DirectN;

[Flags]
public enum SCROLLINFO_MASK : uint
{
    SIF_ALL = 23,
    SIF_DISABLENOSCROLL = 8,
    SIF_PAGE = 2,
    SIF_POS = 4,
    SIF_RANGE = 1,
    SIF_TRACKPOS = 16,
}
