namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpPathIterator
{
    public static readonly GpPathIterator Null = new();
    
    public nint Value;
}
