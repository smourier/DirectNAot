#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_DIGITALWINDOW_SETTING
{
    public int OriginX;
    public int OriginY;
    public int WindowSize;
    public uint Reserved;
}
