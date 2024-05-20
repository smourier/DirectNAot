#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_toponode_drain_mode
public enum MF_TOPONODE_DRAIN_MODE
{
    MF_TOPONODE_DRAIN_DEFAULT = 0,
    MF_TOPONODE_DRAIN_ALWAYS = 1,
    MF_TOPONODE_DRAIN_NEVER = 2,
}
