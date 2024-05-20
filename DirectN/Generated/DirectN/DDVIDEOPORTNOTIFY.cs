#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTNOTIFY
{
    public long ApproximateTimeStamp;
    public int lField;
    public uint dwSurfaceIndex;
    public int lDone;
}
