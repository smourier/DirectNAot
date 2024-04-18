namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-elemdesc~r1
[StructLayout(LayoutKind.Sequential)]
public partial struct ELEMDESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public IDLDESC idldesc;
        
        [FieldOffset(0)]
        public PARAMDESC paramdesc;
    }
    
    public TYPEDESC tdesc;
    public _Anonymous_e__Union Anonymous;
}
