#nullable enable
namespace DirectN;

public partial struct KSDS3D_BUFFER_ALL
{
    public DS3DVECTOR Position;
    public DS3DVECTOR Velocity;
    public uint InsideConeAngle;
    public uint OutsideConeAngle;
    public DS3DVECTOR ConeOrientation;
    public int ConeOutsideVolume;
    public float MinDistance;
    public float MaxDistance;
    public uint Mode;
}
