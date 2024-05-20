#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ne-dxva9typ-copp_bustype
public enum COPP_BusType
{
    COPP_BusType_Unknown = 0,
    COPP_BusType_PCI = 1,
    COPP_BusType_PCIX = 2,
    COPP_BusType_PCIExpress = 3,
    COPP_BusType_AGP = 4,
    COPP_BusType_Integrated = int.MinValue,
    COPP_BusType_ForceDWORD = int.MaxValue,
}
