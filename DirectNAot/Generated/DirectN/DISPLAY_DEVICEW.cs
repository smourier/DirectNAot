#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-display_devicew
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAY_DEVICEW
{
    public uint cb;
    public InlineArraySystemChar32 DeviceName;
    public InlineArraySystemChar128 DeviceString;
    public uint StateFlags;
    public InlineArraySystemChar128 DeviceID;
    public InlineArraySystemChar128 DeviceKey;
}
