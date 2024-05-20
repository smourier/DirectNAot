#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HKEY
{
    public static readonly HKEY Null = new();
    
    public nint Value;
}
