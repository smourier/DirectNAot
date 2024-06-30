#nullable enable
namespace DirectN;

public partial struct PANEL_GET_BACKLIGHT_REDUCTION
{
    public ushort BacklightUsersetting;
    public ushort BacklightEffective;
    public BACKLIGHT_REDUCTION_GAMMA_RAMP GammaRamp;
}
