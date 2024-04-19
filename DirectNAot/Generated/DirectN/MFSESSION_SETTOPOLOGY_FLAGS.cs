namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfsession_settopology_flags
public enum MFSESSION_SETTOPOLOGY_FLAGS
{
    MFSESSION_SETTOPOLOGY_IMMEDIATE = 1,
    MFSESSION_SETTOPOLOGY_NORESOLUTION = 2,
    MFSESSION_SETTOPOLOGY_CLEAR_CURRENT = 4,
}
