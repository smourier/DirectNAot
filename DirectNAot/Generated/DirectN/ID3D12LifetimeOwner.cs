namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12lifetimeowner
[GeneratedComInterface, Guid("e667af9f-cd56-4f46-83ce-032e595d70a8")]
public partial interface ID3D12LifetimeOwner
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12lifetimeowner-lifetimestateupdated
    [PreserveSig]
    public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState);
}
