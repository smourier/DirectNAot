#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TIMECODE_NODE_S
{
    public KSP_NODE NodeProperty;
    public TIMECODE_SAMPLE TimecodeSamp;
}
