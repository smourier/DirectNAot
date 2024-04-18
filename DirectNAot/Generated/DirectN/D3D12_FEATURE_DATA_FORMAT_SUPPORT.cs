namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_format_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_FORMAT_SUPPORT
{
    public DXGI_FORMAT Format;
    public D3D12_FORMAT_SUPPORT1 Support1;
    public D3D12_FORMAT_SUPPORT2 Support2;
}
