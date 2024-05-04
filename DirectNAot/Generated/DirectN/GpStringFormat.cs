#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpStringFormat
{
    public static readonly GpStringFormat Null = new();
    
    public nint Value;
}
