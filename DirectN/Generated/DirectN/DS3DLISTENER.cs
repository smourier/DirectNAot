#nullable enable
namespace DirectN;

public partial struct DS3DLISTENER
{
    public uint dwSize;
    public D3DVECTOR vPosition;
    public D3DVECTOR vVelocity;
    public D3DVECTOR vOrientFront;
    public D3DVECTOR vOrientTop;
    public float flDistanceFactor;
    public float flRolloffFactor;
    public float flDopplerFactor;
}
