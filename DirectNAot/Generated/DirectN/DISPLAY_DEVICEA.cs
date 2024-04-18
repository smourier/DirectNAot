namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-display_devicea
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAY_DEVICEA
{
    public uint cb;
    public InlineArrayFoundationCHAR32 DeviceName;
    public InlineArrayFoundationCHAR128 DeviceString;
    public uint StateFlags;
    public InlineArrayFoundationCHAR128 DeviceID;
    public InlineArrayFoundationCHAR128 DeviceKey;
}
