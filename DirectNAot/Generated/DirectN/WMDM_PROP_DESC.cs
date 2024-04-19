namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-prop-desc
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDM_PROP_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _ValidValues_e__Union
    {
        [FieldOffset(0)]
        public WMDM_PROP_VALUES_RANGE ValidValuesRange;
        
        [FieldOffset(0)]
        public WMDM_PROP_VALUES_ENUM EnumeratedValidValues;
    }
    
    public PWSTR pwszPropName;
    public WMDM_ENUM_PROP_VALID_VALUES_FORM ValidValuesForm;
    public _ValidValues_e__Union ValidValues;
}
