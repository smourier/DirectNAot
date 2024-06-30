#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_decoder_extension
public partial struct D3D11_VIDEO_DECODER_EXTENSION
{
    public uint Function;
    public nint pPrivateInputData;
    public uint PrivateInputDataSize;
    public nint pPrivateOutputData;
    public uint PrivateOutputDataSize;
    public uint ResourceCount;
    public nint ppResourceList;
}
