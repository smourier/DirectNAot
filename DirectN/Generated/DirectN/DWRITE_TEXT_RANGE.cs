#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_text_range
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_TEXT_RANGE
{
    public uint startPosition;
    public uint length;
}
