namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subresource_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SUBRESOURCE_INFO
{
    public ulong Offset;
    public uint RowPitch;
    public uint DepthPitch;
}
