﻿namespace DirectN;

[GeneratedComInterface, Guid("5af5c532-4c91-4cd0-b541-15a405395fc5")]
public partial interface ID3D12Device12 : ID3D12Device11
{
    [PreserveSig]
    D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo3(uint visibleMask, uint numResourceDescs, in D3D12_RESOURCE_DESC1 pResourceDescs, nint/* nint */ pNumCastableFormats, nint/* nint */ ppCastableFormats, nint/* nint */ pResourceAllocationInfo1);
}
