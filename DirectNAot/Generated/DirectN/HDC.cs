namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDC
{
    public static readonly HDC Null = new();
    
    public nint Value;
}
