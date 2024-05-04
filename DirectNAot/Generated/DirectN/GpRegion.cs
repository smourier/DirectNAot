#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpRegion
{
    public static readonly GpRegion Null = new();
    
    public nint Value;
}
