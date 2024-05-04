#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_format_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_FORMAT_SUPPORT
{
    public DXGI_FORMAT InFormat;
    public uint OutFormatSupport;
}
