namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSCNTL_SCREEN_INFO
{
    public COORD Position;
    public COORD ScreenSize;
    public uint nNumberOfChars;
}
