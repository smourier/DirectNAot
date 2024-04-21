namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FontFamily
{
    public static readonly FontFamily Null = new();
    
    public nint Value;
}
