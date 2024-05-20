#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_WRITE_TO_FRAME_BUFFER
{
    public nint SrcBuffer;
    public FSCNTL_SCREEN_INFO DestScreen;
}
