namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRULEHANDLE
{
    public static readonly SPRULEHANDLE Null = new();
    
    public nint Value;
}
