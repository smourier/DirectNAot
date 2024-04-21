namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct Region
{
    public static readonly Region Null = new();
    
    public nint Value;
}
