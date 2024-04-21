namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HRGN
{
    public static readonly HRGN Null = new();
    
    public nint Value;
}
