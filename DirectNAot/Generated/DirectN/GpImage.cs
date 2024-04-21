namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpImage
{
    public static readonly GpImage Null = new();
    
    public nint Value;
}
