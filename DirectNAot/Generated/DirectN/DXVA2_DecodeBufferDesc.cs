#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_decodebufferdesc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_DecodeBufferDesc
{
    public uint CompressedBufferType;
    public uint BufferIndex;
    public uint DataOffset;
    public uint DataSize;
    public uint FirstMBaddress;
    public uint NumMBsInBuffer;
    public uint Width;
    public uint Height;
    public uint Stride;
    public uint ReservedBits;
    public nint pvPVPState;
}
