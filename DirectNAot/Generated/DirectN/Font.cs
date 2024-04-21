namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct Font
{
    public static readonly Font Null = new();
    
    public nint Value;
}
