#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicddsformatinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct WICDdsFormatInfo
{
    public DXGI_FORMAT DxgiFormat;
    public uint BytesPerBlock;
    public uint BlockWidth;
    public uint BlockHeight;
}
