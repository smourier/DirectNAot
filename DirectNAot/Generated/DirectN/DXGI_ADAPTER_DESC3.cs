namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/ns-dxgi1_6-dxgi_adapter_desc3
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_ADAPTER_DESC3
{
    public InlineArrayChar128 Description;
    public uint VendorId;
    public uint DeviceId;
    public uint SubSysId;
    public uint Revision;
    public nuint DedicatedVideoMemory;
    public nuint DedicatedSystemMemory;
    public nuint SharedSystemMemory;
    public LUID AdapterLuid;
    public DXGI_ADAPTER_FLAG3 Flags;
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
}
