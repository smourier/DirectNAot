#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDISTRM
{
    public static readonly HMIDISTRM Null = new();
    
    public nint Value;
}
