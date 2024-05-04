#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CustomLineCap
{
    public static readonly CustomLineCap Null = new();
    
    public nint Value;
}
