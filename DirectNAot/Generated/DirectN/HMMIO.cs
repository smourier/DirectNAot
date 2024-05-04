#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMMIO
{
    public static readonly HMMIO Null = new();
    
    public nint Value;
}
