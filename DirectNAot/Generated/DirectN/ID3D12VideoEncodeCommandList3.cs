﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoencodecommandlist3
[GeneratedComInterface, Guid("7f027b22-1515-4e85-aa0d-026486580576")]
public partial interface ID3D12VideoEncodeCommandList3 : ID3D12VideoEncodeCommandList2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist3-barrier
    [PreserveSig]
    void Barrier(uint NumBarrierGroups, [MarshalUsing(CountElementName = nameof(NumBarrierGroups))] in D3D12_BARRIER_GROUP[] pBarrierGroups);
}
