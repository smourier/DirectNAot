namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_toponode_flush_mode
public enum MF_TOPONODE_FLUSH_MODE
{
    MF_TOPONODE_FLUSH_ALWAYS = 0,
    MF_TOPONODE_FLUSH_SEEK = 1,
    MF_TOPONODE_FLUSH_NEVER = 2,
}
