#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_statusflags
public enum COPP_StatusFlags
{
    COPP_StatusNormal = 0,
    COPP_LinkLost = 1,
    COPP_RenegotiationRequired = 2,
    COPP_StatusFlagsReserved = -4,
}
