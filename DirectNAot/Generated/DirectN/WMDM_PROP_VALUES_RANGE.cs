namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-prop-values-range
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDM_PROP_VALUES_RANGE
{
    public PROPVARIANT rangeMin;
    public PROPVARIANT rangeMax;
    public PROPVARIANT rangeStep;
}
