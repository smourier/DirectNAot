#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_source_device_name
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public InlineArraySystemChar32 viewGdiDeviceName;
}
