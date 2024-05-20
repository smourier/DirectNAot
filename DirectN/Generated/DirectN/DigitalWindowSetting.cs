#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-digitalwindowsetting
[StructLayout(LayoutKind.Sequential)]
public partial struct DigitalWindowSetting
{
    public double OriginX;
    public double OriginY;
    public double WindowSize;
}
