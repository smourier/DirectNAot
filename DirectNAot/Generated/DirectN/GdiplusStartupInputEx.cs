namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GdiplusStartupInputEx
{
    public GdiplusStartupInput Base;
    public int StartupParameters;
}
