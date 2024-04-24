namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11on12/nn-d3d11on12-id3d11on12device
[GeneratedComInterface, Guid("85611e73-70a9-490e-9614-a9e302777904")]
public partial interface ID3D11On12Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device-createwrappedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWrappedResource(nint pResource12, in D3D11_RESOURCE_FLAGS pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppResource11);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device-releasewrappedresources
    [PreserveSig]
    void ReleaseWrappedResources([MarshalUsing(CountElementName = nameof(NumResources))] in ID3D11Resource[] ppResources, uint NumResources);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device-acquirewrappedresources
    [PreserveSig]
    void AcquireWrappedResources([MarshalUsing(CountElementName = nameof(NumResources))] in ID3D11Resource[] ppResources, uint NumResources);
}
