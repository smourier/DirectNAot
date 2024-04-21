namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LRESULT
{
    public static readonly LRESULT Null = new();
    
    public nint Value;
}
