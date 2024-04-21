namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GLUnurbs
{
    public static readonly GLUnurbs Null = new();
    
    public nint Value;
}
