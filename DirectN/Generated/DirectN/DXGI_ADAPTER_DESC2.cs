#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_adapter_desc2
public partial struct DXGI_ADAPTER_DESC2
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
    public uint Flags;
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
}
