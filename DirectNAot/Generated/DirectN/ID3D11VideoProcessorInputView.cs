#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videoprocessorinputview
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("11ec5a5f-51dc-4945-ab34-6e8c21300ea5")]
public partial interface ID3D11VideoProcessorInputView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorinputview-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc);
}
