#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HBRUSH
{
    public static readonly HBRUSH Null = new();
    
    public nint Value;
}
