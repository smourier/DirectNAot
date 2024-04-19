﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device1
[GeneratedComInterface, Guid("77acce80-638e-4e65-8895-c1f23386863e")]
public partial interface ID3D12Device1 : ID3D12Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device1-createpipelinelibrary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePipelineLibrary(nint pLibraryBlob, nuint BlobLength, in Guid riid, out nint ppPipelineLibrary);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device1-seteventonmultiplefencecompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEventOnMultipleFenceCompletion(in ID3D12Fence ppFences, in ulong pFenceValues, uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, HANDLE hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device1-setresidencypriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResidencyPriority(uint NumObjects, in ID3D12Pageable ppObjects, in D3D12_RESIDENCY_PRIORITY pPriorities);
}
