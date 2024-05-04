#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDEV
{
    public static readonly HDEV Null = new();
    
    public nint Value;
}
