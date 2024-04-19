namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-prop-config
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDM_PROP_CONFIG
{
    public uint nPreference;
    public uint nPropDesc;
    public nint pPropDesc;
}
