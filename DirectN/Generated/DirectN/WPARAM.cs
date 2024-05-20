#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WPARAM
{
    public static readonly WPARAM Null = new();
    
    public nuint Value;
}
