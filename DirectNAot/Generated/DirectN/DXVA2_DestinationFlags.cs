#nullable enable
namespace DirectN;

public enum DXVA2_DestinationFlags
{
    DXVA2_DestinationFlag_Background_Changed = 1,
    DXVA2_DestinationFlag_TargetRect_Changed = 2,
    DXVA2_DestinationFlag_ColorData_Changed = 4,
    DXVA2_DestinationFlag_Alpha_Changed = 8,
    DXVA2_DestinationFlag_RFF = 65536,
    DXVA2_DestinationFlag_TFF = 131072,
    DXVA2_DestinationFlag_RFF_TFF_Present = 262144,
    DXVA2_DestinationFlagMask = -65521,
}
