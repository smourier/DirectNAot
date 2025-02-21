#nullable enable
namespace DirectN;

[Flags]
public enum NOTIFY_ICON_INFOTIP_FLAGS : uint
{
    NIIF_NONE = 0,
    NIIF_INFO = 1,
    NIIF_WARNING = 2,
    NIIF_ERROR = 3,
    NIIF_USER = 4,
    NIIF_ICON_MASK = 15,
    NIIF_NOSOUND = 16,
    NIIF_LARGE_ICON = 32,
    NIIF_RESPECT_QUIET_TIME = 128,
}
