namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpFontFamily
{
    public static readonly GpFontFamily Null = new();
    
    public nint Value;
}
