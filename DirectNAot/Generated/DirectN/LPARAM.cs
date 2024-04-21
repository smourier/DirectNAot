namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LPARAM
{
    public static readonly LPARAM Null = new();
    
    public nint Value;
}
