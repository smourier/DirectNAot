namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_COPY_FRAME_BUFFER
{
    public FSCNTL_SCREEN_INFO SrcScreen;
    public FSCNTL_SCREEN_INFO DestScreen;
}
