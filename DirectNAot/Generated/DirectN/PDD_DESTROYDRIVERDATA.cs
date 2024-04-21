namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PDD_DESTROYDRIVERDATA
{
    public static readonly PDD_DESTROYDRIVERDATA Null = new();
    
    public nint Value;
}
