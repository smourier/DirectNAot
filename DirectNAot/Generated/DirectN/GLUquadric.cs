namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GLUquadric
{
    public static readonly GLUquadric Null = new();
    
    public nint Value;
}
