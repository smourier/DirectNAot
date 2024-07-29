#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device3
[GeneratedComInterface, Guid("81dadc15-2bad-4392-93c5-101345c4aa98")]
public partial interface ID3D12Device3 : ID3D12Device2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device3-openexistingheapfromaddress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenExistingHeapFromAddress(nint pAddress, in Guid riid, out nint /* void */ ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device3-openexistingheapfromfilemapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenExistingHeapFromFileMapping(HANDLE hFileMapping, in Guid riid, out nint /* void */ ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device3-enqueuemakeresident
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, uint NumObjects, [In][MarshalUsing(CountElementName = nameof(NumObjects))] ID3D12Pageable[] ppObjects, ID3D12Fence pFenceToSignal, ulong FenceValueToSignal);
}
