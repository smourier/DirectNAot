namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDS3D_LISTENER_ALL
{
    public DS3DVECTOR Position;
    public DS3DVECTOR Velocity;
    public DS3DVECTOR OrientFront;
    public DS3DVECTOR OrientTop;
    public float DistanceFactor;
    public float RolloffFactor;
    public float DopplerFactor;
}
