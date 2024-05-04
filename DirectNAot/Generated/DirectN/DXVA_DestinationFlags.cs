#nullable enable
namespace DirectN;

public enum DXVA_DestinationFlags
{
    DXVA_DestinationFlagMask = 15,
    DXVA_DestinationFlag_Background_Changed = 1,
    DXVA_DestinationFlag_TargetRect_Changed = 2,
    DXVA_DestinationFlag_ColorData_Changed = 4,
    DXVA_DestinationFlag_Alpha_Changed = 8,
}
