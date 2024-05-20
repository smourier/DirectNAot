#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACCEL
{
    public static readonly HACCEL Null = new();
    
    public nint Value;
}
