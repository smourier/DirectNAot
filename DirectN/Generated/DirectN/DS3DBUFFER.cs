#nullable enable
namespace DirectN;

public partial struct DS3DBUFFER
{
    public uint dwSize;
    public D3DVECTOR vPosition;
    public D3DVECTOR vVelocity;
    public uint dwInsideConeAngle;
    public uint dwOutsideConeAngle;
    public D3DVECTOR vConeOrientation;
    public int lConeOutsideVolume;
    public float flMinDistance;
    public float flMaxDistance;
    public uint dwMode;
}
