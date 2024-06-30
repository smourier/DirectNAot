#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-display_devicew
public partial struct DISPLAY_DEVICEW
{
    public uint cb;
    public InlineArraySystemChar_32 DeviceName;
    public InlineArraySystemChar_128 DeviceString;
    public uint StateFlags;
    public InlineArraySystemChar_128 DeviceID;
    public InlineArraySystemChar_128 DeviceKey;
}
