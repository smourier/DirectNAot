namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETHEAPALIGNMENTDATA
{
    public nuint dwInstance;
    public uint dwHeap;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetHeapAlignment;
    public HEAPALIGNMENT Alignment;
}
