namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CachedBitmap
{
    public static readonly CachedBitmap Null = new();
    
    public nint Value;
}
