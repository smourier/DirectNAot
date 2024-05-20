#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HGLRC
{
    public static readonly HGLRC Null = new();
    
    public nint Value;
}
