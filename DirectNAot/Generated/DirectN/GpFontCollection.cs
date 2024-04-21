namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpFontCollection
{
    public static readonly GpFontCollection Null = new();
    
    public nint Value;
}
