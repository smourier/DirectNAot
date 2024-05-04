#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpAdjustableArrowCap
{
    public static readonly GpAdjustableArrowCap Null = new();
    
    public nint Value;
}
