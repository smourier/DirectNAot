#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-format-capability
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDM_FORMAT_CAPABILITY
{
    public uint nPropConfig;
    public nint pConfigs;
}
