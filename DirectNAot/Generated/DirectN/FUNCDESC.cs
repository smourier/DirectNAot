namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-funcdesc
[StructLayout(LayoutKind.Sequential)]
public partial struct FUNCDESC
{
    public int memid;
    public nint lprgscode;
    public nint lprgelemdescParam;
    public FUNCKIND funckind;
    public INVOKEKIND invkind;
    public CALLCONV callconv;
    public short cParams;
    public short cParamsOpt;
    public short oVft;
    public short cScodes;
    public ELEMDESC elemdescFunc;
    public FUNCFLAGS wFuncFlags;
}
