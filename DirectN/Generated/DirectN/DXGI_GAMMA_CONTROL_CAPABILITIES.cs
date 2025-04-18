#nullable enable
namespace DirectN;

public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
{
    public BOOL ScaleAndOffsetSupported;
    public float MaxConvertedValue;
    public float MinConvertedValue;
    public uint NumGammaControlPoints;
    public InlineArraySingle_1025 ControlPointPositions;
}
