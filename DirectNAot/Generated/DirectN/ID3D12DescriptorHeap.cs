namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12descriptorheap
[GeneratedComInterface, Guid("8efb471d-616c-4f49-90f7-127bb763fa51")]
public partial interface ID3D12DescriptorHeap : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12descriptorheap-getdesc
    [PreserveSig]
    public D3D12_DESCRIPTOR_HEAP_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12descriptorheap-getcpudescriptorhandleforheapstart
    [PreserveSig]
    public D3D12_CPU_DESCRIPTOR_HANDLE GetCPUDescriptorHandleForHeapStart();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12descriptorheap-getgpudescriptorhandleforheapstart
    [PreserveSig]
    public D3D12_GPU_DESCRIPTOR_HANDLE GetGPUDescriptorHandleForHeapStart();
}
