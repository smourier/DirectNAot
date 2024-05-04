#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOENGINE_DEVICECONTROLS
{
    public EDeviceControlUseType Volume;
    public EDeviceControlUseType Mute;
    public EDeviceControlUseType PeakMeter;
}
