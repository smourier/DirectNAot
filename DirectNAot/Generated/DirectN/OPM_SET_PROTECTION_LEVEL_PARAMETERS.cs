namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_set_protection_level_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_SET_PROTECTION_LEVEL_PARAMETERS
{
    public uint ulProtectionType;
    public uint ulProtectionLevel;
    public uint Reserved;
    public uint Reserved2;
}
