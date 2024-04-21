namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDI
{
    public static readonly HMIDI Null = new();
    
    public nint Value;
}
