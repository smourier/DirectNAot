#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_counter_info
public partial struct D3D11_COUNTER_INFO
{
    public D3D11_COUNTER LastDeviceDependentCounter;
    public uint NumSimultaneousCounters;
    public byte NumDetectableParallelUnits;
}
