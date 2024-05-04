#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MACINFO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fUsed;
    public InlineArrayByte36 abMacState;
}
