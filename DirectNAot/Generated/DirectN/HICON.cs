#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HICON
{
    public static readonly HICON Null = new();
    
    public nint Value;
}
