#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HCURSOR
{
    public static readonly HCURSOR Null = new();
    
    public nint Value;
}
