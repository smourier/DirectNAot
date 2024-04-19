﻿namespace DirectN;

[GeneratedComInterface, Guid("16be35a2-bfd6-49f2-bcae-eaae4aff862d")]
public partial interface ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue
{
    [PreserveSig]
    void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_ACCESS Access);
    
    [PreserveSig]
    void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout);
}
