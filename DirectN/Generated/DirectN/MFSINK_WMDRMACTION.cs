#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/ne-wmcontainer-mfsink_wmdrmaction
public enum MFSINK_WMDRMACTION
{
    MFSINK_WMDRMACTION_UNDEFINED = 0,
    MFSINK_WMDRMACTION_ENCODE = 1,
    MFSINK_WMDRMACTION_TRANSCODE = 2,
    MFSINK_WMDRMACTION_TRANSCRYPT = 3,
    MFSINK_WMDRMACTION_LAST = 3,
}
