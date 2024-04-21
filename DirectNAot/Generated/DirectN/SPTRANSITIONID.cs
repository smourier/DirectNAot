namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTRANSITIONID
{
    public static readonly SPTRANSITIONID Null = new();
    
    public nint Value;
}
