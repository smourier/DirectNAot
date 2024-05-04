#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_adapter_name
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_ADAPTER_NAME
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public InlineArraySystemChar128 adapterDevicePath;
}
