#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_DROPPEDFRAMES_CURRENT_S
{
    public KSIDENTIFIER Property;
    public long PictureNumber;
    public long DropCount;
    public uint AverageFrameSize;
}
