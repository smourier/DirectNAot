#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASERULEHANDLE
{
    public static readonly SPPHRASERULEHANDLE Null = new();
    
    public nint Value;
}
