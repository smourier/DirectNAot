namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpGraphics
{
    public static readonly GpGraphics Null = new();
    
    public nint Value;
}
