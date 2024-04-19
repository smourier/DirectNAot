namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videodecoderoutputview
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c2931aea-2a85-4f20-860f-fba1fd256e18")]
public partial interface ID3D11VideoDecoderOutputView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodecoderoutputview-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
}
