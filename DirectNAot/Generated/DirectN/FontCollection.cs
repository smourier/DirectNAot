namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FontCollection
{
    public static readonly FontCollection Null = new();
    
    public nint Value;
}
