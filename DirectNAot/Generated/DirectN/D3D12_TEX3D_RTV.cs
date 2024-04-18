namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex3d_rtv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEX3D_RTV
{
    public uint MipSlice;
    public uint FirstWSlice;
    public uint WSize;
}
