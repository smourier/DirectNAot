namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_hdcp_protection_level
public enum COPP_HDCP_Protection_Level
{
    COPP_HDCP_Level0 = 0,
    COPP_HDCP_LevelMin = 0,
    COPP_HDCP_Level1 = 1,
    COPP_HDCP_LevelMax = 1,
    COPP_HDCP_ForceDWORD = int.MaxValue,
}
