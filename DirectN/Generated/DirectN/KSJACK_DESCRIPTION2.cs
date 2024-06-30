#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/ns-devicetopology-ksjack_description2
public partial struct KSJACK_DESCRIPTION2
{
    public uint DeviceStateInfo;
    public uint JackCapabilities;
}
