#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_acp_protection_level
public enum COPP_ACP_Protection_Level
{
    COPP_ACP_Level0 = 0,
    COPP_ACP_LevelMin = 0,
    COPP_ACP_Level1 = 1,
    COPP_ACP_Level2 = 2,
    COPP_ACP_Level3 = 3,
    COPP_ACP_LevelMax = 3,
    COPP_ACP_ForceDWORD = int.MaxValue,
}
