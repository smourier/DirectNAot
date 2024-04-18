namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/nn-dxgi1_5-idxgifactory5
[GeneratedComInterface, Guid("7632e1f5-ee65-4dca-87fd-84cd75f8838d")]
public partial interface IDXGIFactory5 : IDXGIFactory4
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_5/nf-dxgi1_5-idxgifactory5-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckFeatureSupport(DXGI_FEATURE Feature, nint pFeatureSupportData, uint FeatureSupportDataSize);
}
