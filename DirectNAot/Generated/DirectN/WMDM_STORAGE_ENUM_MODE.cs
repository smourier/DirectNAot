#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-storage-enum-mode
public enum WMDM_STORAGE_ENUM_MODE
{
    ENUM_MODE_RAW = 0,
    ENUM_MODE_USE_DEVICE_PREF = 1,
    ENUM_MODE_METADATA_VIEWS = 2,
}
