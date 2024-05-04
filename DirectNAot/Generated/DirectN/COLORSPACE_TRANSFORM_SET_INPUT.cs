#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM_SET_INPUT
{
    public OUTPUT_WIRE_COLOR_SPACE_TYPE OutputWireColorSpaceExpected;
    public OUTPUT_WIRE_FORMAT OutputWireFormatExpected;
    public COLORSPACE_TRANSFORM ColorSpaceTransform;
}
