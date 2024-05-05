#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HGDIOBJ
{
    public static readonly HGDIOBJ Null = new();
    
    public nint Value;
}
