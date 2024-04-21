namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpFont
{
    public static readonly GpFont Null = new();
    
    public nint Value;
}
