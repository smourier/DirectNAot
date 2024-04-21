namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodevice1
[GeneratedComInterface, Guid("981611ad-a144-4c83-9890-f30e26d658ab")]
public partial interface ID3D12VideoDevice1 : ID3D12VideoDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice1-createvideomotionestimator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoMotionEstimator(in D3D12_VIDEO_MOTION_ESTIMATOR_DESC pDesc, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoMotionEstimator);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice1-createvideomotionvectorheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoMotionVectorHeap(in D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC pDesc, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoMotionVectorHeap);
}
