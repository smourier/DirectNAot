#nullable enable
namespace DirectN;

[Flags]
public enum NOTIFY_ICON_DATA_FLAGS : uint
{
    NIF_MESSAGE = 1,
    NIF_ICON = 2,
    NIF_TIP = 4,
    NIF_STATE = 8,
    NIF_INFO = 16,
    NIF_GUID = 32,
    NIF_REALTIME = 64,
    NIF_SHOWTIP = 128,
}
