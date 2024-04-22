namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_REVERSE_MOUSE_POINTER
{
    public FSCNTL_SCREEN_INFO Screen;
    public uint dwType;
}
