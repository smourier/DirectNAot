#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_target_preferred_mode
public partial struct DISPLAYCONFIG_TARGET_PREFERRED_MODE
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public uint width;
    public uint height;
    public DISPLAYCONFIG_TARGET_MODE targetMode;
}
