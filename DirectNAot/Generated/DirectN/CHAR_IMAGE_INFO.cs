#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CHAR_IMAGE_INFO
{
    public CHAR_INFO CharInfo;
    public FONT_IMAGE_INFO FontImageInfo;
}
