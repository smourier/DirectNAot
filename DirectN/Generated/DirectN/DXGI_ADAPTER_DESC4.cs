#nullable enable
namespace DirectN;

public partial struct DXGI_ADAPTER_DESC4
{
    public InlineArraySystemChar_128 Description;
    public uint VendorId;
    public uint DeviceId;
    public uint SubSysId;
    public uint Revision;
    public nuint DedicatedVideoMemory;
    public nuint DedicatedSystemMemory;
    public nuint SharedSystemMemory;
    public LUID AdapterLuid;
    public DXGI_ADAPTER_FLAG4 Flags;
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
}
