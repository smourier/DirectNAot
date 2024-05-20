#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECOCONTEXTHANDLE
{
    public static readonly SPRECOCONTEXTHANDLE Null = new();
    
    public nint Value;
}
