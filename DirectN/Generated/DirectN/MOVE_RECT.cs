#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MOVE_RECT
{
    public POINT SourcePoint;
    public RECT DestRect;
}
