#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11videocontext2
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("c4e7374c-6243-4d1b-ae87-52b4f740e261")]
public partial interface ID3D11VideoContext2 : ID3D11VideoContext1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videocontext2-videoprocessorsetoutputhdrmetadata
    [PreserveSig]
    void VideoProcessorSetOutputHDRMetaData(ID3D11VideoProcessor pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, uint Size, nint /* optional void* */ pHDRMetaData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videocontext2-videoprocessorgetoutputhdrmetadata
    [PreserveSig]
    void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor pVideoProcessor, out DXGI_HDR_METADATA_TYPE pType, uint Size, nint /* optional void* */ pMetaData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videocontext2-videoprocessorsetstreamhdrmetadata
    [PreserveSig]
    void VideoProcessorSetStreamHDRMetaData(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, uint Size, nint /* optional void* */ pHDRMetaData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videocontext2-videoprocessorgetstreamhdrmetadata
    [PreserveSig]
    void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out DXGI_HDR_METADATA_TYPE pType, uint Size, nint /* optional void* */ pMetaData);
}
