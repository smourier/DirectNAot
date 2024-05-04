#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicddsparameters
[StructLayout(LayoutKind.Sequential)]
public partial struct WICDdsParameters
{
    public uint Width;
    public uint Height;
    public uint Depth;
    public uint MipLevels;
    public uint ArraySize;
    public DXGI_FORMAT DxgiFormat;
    public WICDdsDimension Dimension;
    public WICDdsAlphaMode AlphaMode;
}
