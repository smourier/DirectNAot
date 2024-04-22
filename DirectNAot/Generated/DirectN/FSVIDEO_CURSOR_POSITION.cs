namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_CURSOR_POSITION
{
    public VIDEO_CURSOR_POSITION Coord;
    public uint dwType;
}
