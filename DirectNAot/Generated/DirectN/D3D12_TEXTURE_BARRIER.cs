﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_texture_barrier
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEXTURE_BARRIER
{
    public D3D12_BARRIER_SYNC SyncBefore;
    public D3D12_BARRIER_SYNC SyncAfter;
    public D3D12_BARRIER_ACCESS AccessBefore;
    public D3D12_BARRIER_ACCESS AccessAfter;
    public D3D12_BARRIER_LAYOUT LayoutBefore;
    public D3D12_BARRIER_LAYOUT LayoutAfter;
    public nint pResource;
    public D3D12_BARRIER_SUBRESOURCE_RANGE Subresources;
    public D3D12_TEXTURE_BARRIER_FLAGS Flags;
}
