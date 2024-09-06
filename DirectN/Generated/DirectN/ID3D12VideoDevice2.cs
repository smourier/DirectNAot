#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodevice2
[GeneratedComInterface, Guid("f019ac49-f838-4a95-9b17-579437c8f513")]
public partial interface ID3D12VideoDevice2 : ID3D12VideoDevice1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice2-createvideodecoder1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoder1(in D3D12_VIDEO_DECODER_DESC pDesc, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, out nint /* void */ ppVideoDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice2-createvideodecoderheap1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoderHeap1(in D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, out nint /* void */ ppVideoDecoderHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice2-createvideoprocessor1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessor1(uint NodeMask, in D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, uint NumInputStreamDescs, [In][MarshalUsing(CountElementName = nameof(NumInputStreamDescs))] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, out nint /* void */ ppVideoProcessor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice2-createvideoextensioncommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoExtensionCommand(in D3D12_VIDEO_EXTENSION_COMMAND_DESC pDesc, nint pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession? pProtectedResourceSession, in Guid riid, out nint /* void */ ppVideoExtensionCommand);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodevice2-executeextensioncommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pExecutionParameters, nuint ExecutionParametersSizeInBytes, nint pOutputData, nuint OutputDataSizeInBytes);
}
