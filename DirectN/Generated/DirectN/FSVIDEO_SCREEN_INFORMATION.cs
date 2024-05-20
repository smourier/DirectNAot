#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_SCREEN_INFORMATION
{
    public COORD ScreenSize;
    public COORD FontSize;
}
