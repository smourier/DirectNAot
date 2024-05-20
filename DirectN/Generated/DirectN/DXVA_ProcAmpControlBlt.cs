#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_ProcAmpControlBlt
{
    public uint Size;
    public RECT DstRect;
    public RECT SrcRect;
    public float Alpha;
    public float Brightness;
    public float Contrast;
    public float Hue;
    public float Saturation;
}
