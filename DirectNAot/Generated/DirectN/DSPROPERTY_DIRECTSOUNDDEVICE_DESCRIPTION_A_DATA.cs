#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA
{
    public DIRECTSOUNDDEVICE_TYPE Type;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public Guid DeviceId;
    public PSTR Description;
    public PSTR Module;
    public PSTR Interface;
    public uint WaveDeviceId;
}
