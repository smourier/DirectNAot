namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PathData
{
    public static readonly PathData Null = new();
    
    public nint Value;
}
