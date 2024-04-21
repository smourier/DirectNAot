namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDHANDLE
{
    public static readonly SPWORDHANDLE Null = new();
    
    public nint Value;
}
