#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_vpdevcaps
public partial struct DXVAHD_VPDEVCAPS
{
    public DXVAHD_DEVICE_TYPE DeviceType;
    public uint DeviceCaps;
    public uint FeatureCaps;
    public uint FilterCaps;
    public uint InputFormatCaps;
    public D3DPOOL InputPool;
    public uint OutputFormatCount;
    public uint InputFormatCount;
    public uint VideoProcessorCount;
    public uint MaxInputStreams;
    public uint MaxStreamStates;
}
