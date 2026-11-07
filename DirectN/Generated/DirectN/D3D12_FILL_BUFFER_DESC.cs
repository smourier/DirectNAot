#nullable enable
namespace DirectN;

public partial struct D3D12_FILL_BUFFER_DESC
{
    public nint pBuffer;
    public ulong Offset;
    public D3D12_CLEAR_DATA FillValue;
    public DXGI_FORMAT Format;
    public uint RawPatternSizeInBytes;
    public uint RepeatCount;
}
