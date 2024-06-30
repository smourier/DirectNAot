#nullable enable
namespace DirectN;

public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA
{
    public Guid DeviceId;
    public InlineArrayFoundationCHAR_256 DescriptionA;
    public InlineArraySystemChar_256 DescriptionW;
    public InlineArrayFoundationCHAR_260 ModuleA;
    public InlineArraySystemChar_260 ModuleW;
    public DIRECTSOUNDDEVICE_TYPE Type;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public uint WaveDeviceId;
    public uint Devnode;
}
