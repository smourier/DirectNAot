#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA
{
    public Guid DeviceId;
    public InlineArrayFoundationCHAR256 DescriptionA;
    public InlineArraySystemChar256 DescriptionW;
    public InlineArrayFoundationCHAR260 ModuleA;
    public InlineArraySystemChar260 ModuleW;
    public DIRECTSOUNDDEVICE_TYPE Type;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public uint WaveDeviceId;
    public uint Devnode;
}
