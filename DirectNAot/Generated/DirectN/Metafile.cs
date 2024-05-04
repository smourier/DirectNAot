#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct Metafile
{
    public static readonly Metafile Null = new();
    
    public nint Value;
}
