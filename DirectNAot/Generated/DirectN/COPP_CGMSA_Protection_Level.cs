namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_cgmsa_protection_level
public enum COPP_CGMSA_Protection_Level
{
    COPP_CGMSA_Disabled = 0,
    COPP_CGMSA_LevelMin = 0,
    COPP_CGMSA_CopyFreely = 1,
    COPP_CGMSA_CopyNoMore = 2,
    COPP_CGMSA_CopyOneGeneration = 3,
    COPP_CGMSA_CopyNever = 4,
    COPP_CGMSA_RedistributionControlRequired = 8,
    COPP_CGMSA_LevelMax = 12,
    COPP_CGMSA_ForceDWORD = 2147483647,
}
