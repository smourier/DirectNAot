#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nn-windows-graphics-holographic-interop-iholographiccamerarenderingparametersinterop
[GeneratedComInterface, Guid("f75b68d6-d1fd-4707-aafd-fa6f4c0e3bf4")]
public partial interface IHolographicCameraRenderingParametersInterop : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerarenderingparametersinterop-commitdirect3d12resource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitDirect3D12Resource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pColorResourceToCommit, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Fence>))] ID3D12Fence pColorResourceFence, ulong colorResourceFenceSignalValue);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerarenderingparametersinterop-commitdirect3d12resourcewithdepthdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitDirect3D12ResourceWithDepthData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pColorResourceToCommit, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Fence>))] ID3D12Fence pColorResourceFence, ulong colorResourceFenceSignalValue, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDepthResourceToCommit, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Fence>))] ID3D12Fence pDepthResourceFence, ulong depthResourceFenceSignalValue);
}
