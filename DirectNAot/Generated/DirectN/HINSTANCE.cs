namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HINSTANCE
{
    public static readonly HINSTANCE Null = new();
    
    public nint Value;
}
