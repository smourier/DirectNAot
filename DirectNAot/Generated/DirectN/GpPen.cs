#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpPen
{
    public static readonly GpPen Null = new();
    
    public nint Value;
}
