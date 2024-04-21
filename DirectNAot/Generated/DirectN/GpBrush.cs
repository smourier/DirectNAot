namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpBrush
{
    public static readonly GpBrush Null = new();
    
    public nint Value;
}
