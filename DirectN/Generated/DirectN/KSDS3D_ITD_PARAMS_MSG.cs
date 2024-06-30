#nullable enable
namespace DirectN;

public partial struct KSDS3D_ITD_PARAMS_MSG
{
    public uint Enabled;
    public KSDS3D_ITD_PARAMS LeftParams;
    public KSDS3D_ITD_PARAMS RightParams;
    public uint Reserved;
}
