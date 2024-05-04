#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpTexture
{
    public static readonly GpTexture Null = new();
    
    public nint Value;
}
