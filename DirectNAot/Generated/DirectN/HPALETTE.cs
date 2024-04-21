namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HPALETTE
{
    public static readonly HPALETTE Null = new();
    
    public nint Value;
}
