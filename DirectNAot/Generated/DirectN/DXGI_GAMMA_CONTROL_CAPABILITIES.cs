namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
{
    [MarshalAs(UnmanagedType.U4)]
    public bool ScaleAndOffsetSupported;
    public float MaxConvertedValue;
    public float MinConvertedValue;
    public uint NumGammaControlPoints;
    public InlineArraySingle1025 ControlPointPositions;
}
