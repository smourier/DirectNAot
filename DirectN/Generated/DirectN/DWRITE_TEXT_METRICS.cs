#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_text_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_TEXT_METRICS
{
    public float left;
    public float top;
    public float width;
    public float widthIncludingTrailingWhitespace;
    public float height;
    public float layoutWidth;
    public float layoutHeight;
    public uint maxBidiReorderingDepth;
    public uint lineCount;
}
