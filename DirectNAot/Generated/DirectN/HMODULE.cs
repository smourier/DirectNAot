#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMODULE
{
    public static readonly HMODULE Null = new();
    
    public nint Value;
}
