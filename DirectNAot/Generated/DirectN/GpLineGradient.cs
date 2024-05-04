#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpLineGradient
{
    public static readonly GpLineGradient Null = new();
    
    public nint Value;
}
