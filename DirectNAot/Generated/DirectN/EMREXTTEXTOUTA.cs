namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrexttextouta
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTTEXTOUTA
{
    public EMR emr;
    public RECTL rclBounds;
    public uint iGraphicsMode;
    public float exScale;
    public float eyScale;
    public EMRTEXT emrtext;
}
