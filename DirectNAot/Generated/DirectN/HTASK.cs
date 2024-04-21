namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HTASK
{
    public static readonly HTASK Null = new();
    
    public nint Value;
}
