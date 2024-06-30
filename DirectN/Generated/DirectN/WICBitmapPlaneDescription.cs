#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicbitmapplanedescription
public partial struct WICBitmapPlaneDescription
{
    public Guid Format;
    public uint Width;
    public uint Height;
}
