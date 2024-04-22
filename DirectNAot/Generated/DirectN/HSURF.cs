namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HSURF
{
    public static readonly HSURF Null = new();
    
    public nint Value;
}
