#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HCOLORSPACE
{
    public static readonly HCOLORSPACE Null = new();
    
    public nint Value;
}
