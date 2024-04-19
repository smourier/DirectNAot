namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-prop-values-enum
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDM_PROP_VALUES_ENUM
{
    public uint cEnumValues;
    public nint pValues;
}
