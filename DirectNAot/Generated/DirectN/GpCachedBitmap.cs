#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpCachedBitmap
{
    public static readonly GpCachedBitmap Null = new();
    
    public nint Value;
}
