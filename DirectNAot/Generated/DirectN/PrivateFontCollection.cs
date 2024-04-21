namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PrivateFontCollection
{
    public static readonly PrivateFontCollection Null = new();
    
    public nint Value;
}
