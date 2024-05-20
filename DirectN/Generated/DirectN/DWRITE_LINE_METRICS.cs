#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_line_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_LINE_METRICS
{
    public uint length;
    public uint trailingWhitespaceLength;
    public uint newlineLength;
    public float height;
    public float baseline;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool isTrimmed;
}
