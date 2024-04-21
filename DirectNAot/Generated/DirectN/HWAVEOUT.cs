namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVEOUT
{
    public static readonly HWAVEOUT Null = new();
    
    public nint Value;
}
