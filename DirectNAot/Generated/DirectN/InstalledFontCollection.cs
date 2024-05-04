#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct InstalledFontCollection
{
    public static readonly InstalledFontCollection Null = new();
    
    public nint Value;
}
