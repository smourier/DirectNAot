#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpInstalledFontCollection
{
    public static readonly GpInstalledFontCollection Null = new();
    
    public nint Value;
}
