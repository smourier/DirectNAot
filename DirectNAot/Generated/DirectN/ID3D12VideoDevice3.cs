#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodevice3
[GeneratedComInterface, Guid("4243adb4-3a32-4666-973c-0ccc5625dc44")]
public partial interface ID3D12VideoDevice3 : ID3D12VideoDevice2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice3-createvideoencoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoEncoder(in D3D12_VIDEO_ENCODER_DESC pDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoEncoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice3-createvideoencoderheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoEncoderHeap(in D3D12_VIDEO_ENCODER_HEAP_DESC pDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoEncoderHeap);
}
