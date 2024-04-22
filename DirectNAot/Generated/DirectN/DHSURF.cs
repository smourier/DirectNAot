namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DHSURF
{
    public static readonly DHSURF Null = new();
    
    public nint Value;
}
