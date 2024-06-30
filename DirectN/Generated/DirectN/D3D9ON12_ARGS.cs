#nullable enable
namespace DirectN;

public partial struct D3D9ON12_ARGS
{
    public BOOL Enable9On12;
    public nint pD3D12Device;
    public InlineArrayIUnknown_2 ppD3D12Queues;
    public uint NumQueues;
    public uint NodeMask;
}
