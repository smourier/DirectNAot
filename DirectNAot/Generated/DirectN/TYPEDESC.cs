namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-typedesc
[StructLayout(LayoutKind.Sequential)]
public partial struct TYPEDESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint lptdesc;
        
        [FieldOffset(0)]
        public nint lpadesc;
        
        [FieldOffset(0)]
        public uint hreftype;
    }
    
    public _Anonymous_e__Union Anonymous;
    public VARENUM vt;
}
