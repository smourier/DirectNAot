#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-vardesc
public partial struct VARDESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint oInst;
        
        [FieldOffset(0)]
        public nint lpvarValue;
    }
    
    public int memid;
    public PWSTR lpstrSchema;
    public _Anonymous_e__Union Anonymous;
    public ELEMDESC elemdescVar;
    public VARFLAGS wVarFlags;
    public VARKIND varkind;
}
