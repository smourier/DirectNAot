#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMDRIVER
{
    public static readonly HACMDRIVER Null = new();
    
    public nint Value;
}
