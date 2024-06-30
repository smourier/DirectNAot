#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_custom_rate_data
public partial struct DXVAHD_CUSTOM_RATE_DATA
{
    public DXVAHD_RATIONAL CustomRate;
    public uint OutputFrames;
    public BOOL InputInterlaced;
    public uint InputFramesOrFields;
}
