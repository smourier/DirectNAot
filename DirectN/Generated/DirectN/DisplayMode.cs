#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-displaymode
[StructLayout(LayoutKind.Sequential)]
public partial struct DisplayMode
{
    public InlineArraySystemChar_32 DeviceName;
    public DEVMODEW devMode;
}
