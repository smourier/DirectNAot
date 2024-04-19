namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_VideoPropertyRange
{
    public float MinValue;
    public float MaxValue;
    public float DefaultValue;
    public float StepSize;
}
