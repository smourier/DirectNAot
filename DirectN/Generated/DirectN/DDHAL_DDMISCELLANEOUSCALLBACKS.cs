#nullable enable
namespace DirectN;

public partial struct DDHAL_DDMISCELLANEOUSCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint GetAvailDriverMemory;
    public nint UpdateNonLocalHeap;
    public nint GetHeapAlignment;
    public nint GetSysmemBltStatus;
}
