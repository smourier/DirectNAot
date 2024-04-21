namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PDD_SETMODEDATA
{
    public static readonly PDD_SETMODEDATA Null = new();
    
    public nint Value;
}
