#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_command_signature_desc
public partial struct D3D12_COMMAND_SIGNATURE_DESC
{
    public uint ByteStride;
    public uint NumArgumentDescs;
    public nint pArgumentDescs;
    public uint NodeMask;
}
