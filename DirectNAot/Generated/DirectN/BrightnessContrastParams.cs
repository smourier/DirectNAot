#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BrightnessContrastParams
{
    public int brightnessLevel;
    public int contrastLevel;
}
