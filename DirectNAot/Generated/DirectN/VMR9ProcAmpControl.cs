#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9procampcontrol
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9ProcAmpControl
{
    public uint dwSize;
    public uint dwFlags;
    public float Brightness;
    public float Contrast;
    public float Hue;
    public float Saturation;
}
