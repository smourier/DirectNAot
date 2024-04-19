namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MICROPHONE_COORDINATES
{
    public ushort usType;
    public short wXCoord;
    public short wYCoord;
    public short wZCoord;
    public short wVerticalAngle;
    public short wHorizontalAngle;
}
