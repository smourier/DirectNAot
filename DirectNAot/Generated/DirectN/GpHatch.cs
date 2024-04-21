namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpHatch
{
    public static readonly GpHatch Null = new();
    
    public nint Value;
}
