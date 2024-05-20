#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_tvprotectionstandard
public enum COPP_TVProtectionStandard
{
    COPP_ProtectionStandard_Unknown = int.MinValue,
    COPP_ProtectionStandard_None = 0,
    COPP_ProtectionStandard_IEC61880_525i = 1,
    COPP_ProtectionStandard_IEC61880_2_525i = 2,
    COPP_ProtectionStandard_IEC62375_625p = 4,
    COPP_ProtectionStandard_EIA608B_525 = 8,
    COPP_ProtectionStandard_EN300294_625i = 16,
    COPP_ProtectionStandard_CEA805A_TypeA_525p = 32,
    COPP_ProtectionStandard_CEA805A_TypeA_750p = 64,
    COPP_ProtectionStandard_CEA805A_TypeA_1125i = 128,
    COPP_ProtectionStandard_CEA805A_TypeB_525p = 256,
    COPP_ProtectionStandard_CEA805A_TypeB_750p = 512,
    COPP_ProtectionStandard_CEA805A_TypeB_1125i = 1024,
    COPP_ProtectionStandard_ARIBTRB15_525i = 2048,
    COPP_ProtectionStandard_ARIBTRB15_525p = 4096,
    COPP_ProtectionStandard_ARIBTRB15_750p = 8192,
    COPP_ProtectionStandard_ARIBTRB15_1125i = 16384,
    COPP_ProtectionStandard_Mask = -2147450881,
    COPP_ProtectionStandard_Reserved = 2147450880,
}
