#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMSTREAM
{
    public static readonly HACMSTREAM Null = new();
    
    public nint Value;
}
