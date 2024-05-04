#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfpolicymanager_action
public enum MFPOLICYMANAGER_ACTION
{
    PEACTION_NO = 0,
    PEACTION_PLAY = 1,
    PEACTION_COPY = 2,
    PEACTION_EXPORT = 3,
    PEACTION_EXTRACT = 4,
    PEACTION_RESERVED1 = 5,
    PEACTION_RESERVED2 = 6,
    PEACTION_RESERVED3 = 7,
    PEACTION_LAST = 7,
}
