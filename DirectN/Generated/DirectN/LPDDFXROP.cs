#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LPDDFXROP
{
    public static readonly LPDDFXROP Null = new();
    
    public nint Value;
}
