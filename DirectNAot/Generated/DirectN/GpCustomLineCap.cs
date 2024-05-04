#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpCustomLineCap
{
    public static readonly GpCustomLineCap Null = new();
    
    public nint Value;
}
