#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMENU
{
    public static readonly HMENU Null = new();
    
    public nint Value;
}
