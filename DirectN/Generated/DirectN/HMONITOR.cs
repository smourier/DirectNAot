#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMONITOR
{
    public static readonly HMONITOR Null = new();
    
    public nint Value;
}
