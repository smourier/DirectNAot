#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMDRIVERID
{
    public static readonly HACMDRIVERID Null = new();
    
    public nint Value;
}
