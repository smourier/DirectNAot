namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_buffer_barrier
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BUFFER_BARRIER
{
    public D3D12_BARRIER_SYNC SyncBefore;
    public D3D12_BARRIER_SYNC SyncAfter;
    public D3D12_BARRIER_ACCESS AccessBefore;
    public D3D12_BARRIER_ACCESS AccessAfter;
    public nint pResource;
    public ulong Offset;
    public ulong Size;
}
