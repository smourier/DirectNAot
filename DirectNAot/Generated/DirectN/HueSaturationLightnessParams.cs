#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HueSaturationLightnessParams
{
    public int hueLevel;
    public int saturationLevel;
    public int lightnessLevel;
}
