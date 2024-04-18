namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDMISCELLANEOUSCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint GetAvailDriverMemory;
    public nint UpdateNonLocalHeap;
    public nint GetHeapAlignment;
    public nint GetSysmemBltStatus;
}
