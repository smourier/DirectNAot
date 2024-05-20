#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DHPDEV
{
    public static readonly DHPDEV Null = new();
    
    public nint Value;
}
