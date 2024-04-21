namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDRVR
{
    public static readonly HDRVR Null = new();
    
    public nint Value;
}
