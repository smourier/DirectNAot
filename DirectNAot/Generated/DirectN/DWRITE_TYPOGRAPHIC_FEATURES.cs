#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_typographic_features
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_TYPOGRAPHIC_FEATURES
{
    public nint features;
    public uint featureCount;
}
