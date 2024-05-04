#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpMetafile
{
    public static readonly GpMetafile Null = new();
    
    public nint Value;
}
