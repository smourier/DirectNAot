#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HFASTMUTEX
{
    public static readonly HFASTMUTEX Null = new();
    
    public nint Value;
}
