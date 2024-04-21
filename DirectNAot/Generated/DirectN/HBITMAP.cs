namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HBITMAP
{
    public static readonly HBITMAP Null = new();
    
    public nint Value;
}
