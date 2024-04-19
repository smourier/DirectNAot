namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETHEAPALIGNMENTDATA
{
    public nuint dwInstance;
    public uint dwHeap;
    public HRESULT ddRVal;
    public nint GetHeapAlignment;
    public HEAPALIGNMENT Alignment;
}
