#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVE
{
    public static readonly HWAVE Null = new();
    
    public nint Value;
}
