namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDRVOBJ
{
    public static readonly HDRVOBJ Null = new();
    
    public nint Value;
}
