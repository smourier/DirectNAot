namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videoprocessoroutputview
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a048285e-25a9-4527-bd93-d68b68c44254")]
public partial interface ID3D11VideoProcessorOutputView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessoroutputview-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc);
}
