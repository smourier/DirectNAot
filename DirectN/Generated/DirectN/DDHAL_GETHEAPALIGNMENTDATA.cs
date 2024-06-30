#nullable enable
namespace DirectN;

public partial struct DDHAL_GETHEAPALIGNMENTDATA
{
    public nuint dwInstance;
    public uint dwHeap;
    public HRESULT ddRVal;
    public nint GetHeapAlignment;
    public HEAPALIGNMENT Alignment;
}
