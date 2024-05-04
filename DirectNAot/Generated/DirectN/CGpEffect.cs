#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CGpEffect
{
    public static readonly CGpEffect Null = new();
    
    public nint Value;
}
