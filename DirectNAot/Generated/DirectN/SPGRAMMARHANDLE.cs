#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPGRAMMARHANDLE
{
    public static readonly SPGRAMMARHANDLE Null = new();
    
    public nint Value;
}
