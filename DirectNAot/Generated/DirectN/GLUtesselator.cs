namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GLUtesselator
{
    public static readonly GLUtesselator Null = new();
    
    public nint Value;
}
