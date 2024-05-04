#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfshutdown_status
public enum MFSHUTDOWN_STATUS
{
    MFSHUTDOWN_INITIATED = 0,
    MFSHUTDOWN_COMPLETED = 1,
}
