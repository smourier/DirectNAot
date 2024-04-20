namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodevice
[GeneratedComInterface, Guid("1f052807-0b46-4acc-8a89-364f793718a4")]
public partial interface ID3D12VideoDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, nint pFeatureSupportData, uint FeatureSupportDataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice-createvideodecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoder(in D3D12_VIDEO_DECODER_DESC pDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice-createvideodecoderheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoderHeap(in D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoDecoderHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice-createvideoprocessor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessor(uint NodeMask, in D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, uint NumInputStreamDescs, in D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC pInputStreamDescs, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppVideoProcessor);
}
