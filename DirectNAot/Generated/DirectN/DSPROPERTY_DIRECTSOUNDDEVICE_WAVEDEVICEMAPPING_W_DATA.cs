namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W_DATA
{
    public PWSTR DeviceName;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public Guid DeviceId;
}
