#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_video_decoder_begin_frame_crypto_session
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION
{
    public nint pCryptoSession;
    public uint BlobSize;
    public nint pBlob;
    public nint pKeyInfoId;
    public uint PrivateDataSize;
    public nint pPrivateData;
}
