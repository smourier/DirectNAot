#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nn-windows-graphics-holographic-interop-iholographicquadlayerupdateparametersinterop
[GeneratedComInterface, Guid("e5f549cd-c909-444f-8809-7cc18a9c8920")]
public partial interface IHolographicQuadLayerUpdateParametersInterop : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerupdateparametersinterop-commitdirect3d12resource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitDirect3D12Resource(ID3D12Resource pColorResourceToCommit, ID3D12Fence pColorResourceFence, ulong colorResourceFenceSignalValue);
}
