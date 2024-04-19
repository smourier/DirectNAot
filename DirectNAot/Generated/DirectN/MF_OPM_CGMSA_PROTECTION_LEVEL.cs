namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_opm_cgmsa_protection_level
public enum MF_OPM_CGMSA_PROTECTION_LEVEL
{
    MF_OPM_CGMSA_OFF = 0,
    MF_OPM_CGMSA_COPY_FREELY = 1,
    MF_OPM_CGMSA_COPY_NO_MORE = 2,
    MF_OPM_CGMSA_COPY_ONE_GENERATION = 3,
    MF_OPM_CGMSA_COPY_NEVER = 4,
    MF_OPM_CGMSA_REDISTRIBUTION_CONTROL_REQUIRED = 8,
}
