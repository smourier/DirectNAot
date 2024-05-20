﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D9ON12_ARGS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable9On12;
    public nint pD3D12Device;
    public InlineArrayIUnknown_2 ppD3D12Queues;
    public uint NumQueues;
    public uint NodeMask;
}