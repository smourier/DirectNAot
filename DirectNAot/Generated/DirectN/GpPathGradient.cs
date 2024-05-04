#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpPathGradient
{
    public static readonly GpPathGradient Null = new();
    
    public nint Value;
}
