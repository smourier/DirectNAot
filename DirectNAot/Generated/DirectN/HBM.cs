#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HBM
{
    public static readonly HBM Null = new();
    
    public nint Value;
}
