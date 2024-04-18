namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/ns-dwrite_2-dwrite_text_metrics1
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_TEXT_METRICS1
{
    public DWRITE_TEXT_METRICS Base;
    public float heightIncludingTrailingWhitespace;
}
