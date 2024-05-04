#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpBitmap
{
    public static readonly GpBitmap Null = new();
    
    public nint Value;
}
