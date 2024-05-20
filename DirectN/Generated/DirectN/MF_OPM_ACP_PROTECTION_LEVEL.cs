#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_opm_acp_protection_level
public enum MF_OPM_ACP_PROTECTION_LEVEL
{
    MF_OPM_ACP_OFF = 0,
    MF_OPM_ACP_LEVEL_ONE = 1,
    MF_OPM_ACP_LEVEL_TWO = 2,
    MF_OPM_ACP_LEVEL_THREE = 3,
}
