#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfpmpsession_creation_flags
public enum MFPMPSESSION_CREATION_FLAGS
{
    MFPMPSESSION_UNPROTECTED_PROCESS = 1,
    MFPMPSESSION_IN_PROCESS = 2,
}
