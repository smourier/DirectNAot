#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DRH_APIBITMAPDATA
{
    public nint pso;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool b;
}
