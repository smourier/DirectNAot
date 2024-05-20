#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDIIN
{
    public static readonly HMIDIIN Null = new();
    
    public nint Value;
}
