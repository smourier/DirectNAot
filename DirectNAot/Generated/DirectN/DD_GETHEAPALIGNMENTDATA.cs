namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmemmgr/ns-dmemmgr-dd_getheapalignmentdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETHEAPALIGNMENTDATA
{
    public nuint dwInstance;
    public uint dwHeap;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetHeapAlignment;
    public HEAPALIGNMENT Alignment;
}
