namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TrackerHandle
{
    public static readonly TrackerHandle Null = new();
    
    public nint Value;
}
