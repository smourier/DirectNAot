#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HIC
{
    public static readonly HIC Null = new();
    
    public nint Value;
}
