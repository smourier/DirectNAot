#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMOBJ
{
    public static readonly HACMOBJ Null = new();
    
    public nint Value;
}
