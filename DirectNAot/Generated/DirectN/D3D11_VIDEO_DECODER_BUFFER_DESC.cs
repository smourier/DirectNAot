namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_decoder_buffer_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_DECODER_BUFFER_DESC
{
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    public uint BufferIndex;
    public uint DataOffset;
    public uint DataSize;
    public uint FirstMBaddress;
    public uint NumMBsInBuffer;
    public uint Width;
    public uint Height;
    public uint Stride;
    public uint ReservedBits;
    public nint pIV;
    public uint IVSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PartialEncryption;
    public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
}
