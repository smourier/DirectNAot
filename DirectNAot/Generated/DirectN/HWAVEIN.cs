namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVEIN
{
    public static readonly HWAVEIN Null = new();
    
    public nint Value;
}
