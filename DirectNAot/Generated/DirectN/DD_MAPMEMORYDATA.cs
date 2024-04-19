namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_mapmemorydata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_MAPMEMORYDATA
{
    public nint lpDD;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bMap;
    public HANDLE hProcess;
    public nuint fpProcess;
    public HRESULT ddRVal;
}
