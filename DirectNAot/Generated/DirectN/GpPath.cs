#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpPath
{
    public static readonly GpPath Null = new();
    
    public nint Value;
}
