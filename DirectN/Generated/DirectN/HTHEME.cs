#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HTHEME
{
    public static readonly HTHEME Null = new();
    
    public nint Value;
}
