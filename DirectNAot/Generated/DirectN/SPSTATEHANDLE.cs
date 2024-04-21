namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSTATEHANDLE
{
    public static readonly SPSTATEHANDLE Null = new();
    
    public nint Value;
}
