namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FONT_IMAGE_INFO
{
    public COORD FontSize;
    public nint ImageBits;
}
