namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getavaildrivermemorydata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETAVAILDRIVERMEMORYDATA
{
    public nint lpDD;
    public DDSCAPS DDSCaps;
    public uint dwTotal;
    public uint dwFree;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetAvailDriverMemory;
}
