#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCONTROL_ACTUAL_FRAME_RATE_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public uint RangeIndex;
    public SIZE Dimensions;
    public long CurrentActualFrameRate;
    public long CurrentMaxAvailableFrameRate;
}
