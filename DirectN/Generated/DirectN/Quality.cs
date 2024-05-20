#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-quality
[StructLayout(LayoutKind.Sequential)]
public partial struct Quality
{
    public QualityMessageType Type;
    public int Proportion;
    public long Late;
    public long TimeStamp;
}
