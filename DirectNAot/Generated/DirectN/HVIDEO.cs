namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HVIDEO
{
    public static readonly HVIDEO Null = new();
    
    public nint Value;
}
