#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/ne-photoacquire-device_selection_device_type
public enum DEVICE_SELECTION_DEVICE_TYPE
{
    DST_UNKNOWN_DEVICE = 0,
    DST_WPD_DEVICE = 1,
    DST_WIA_DEVICE = 2,
    DST_STI_DEVICE = 3,
    DSF_TWAIN_DEVICE = 4,
    DST_FS_DEVICE = 5,
    DST_DV_DEVICE = 6,
}
