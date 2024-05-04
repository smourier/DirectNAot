#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GdiPlusPathData
{
    public static readonly GdiPlusPathData Null = new();
    
    public nint Value;
}
