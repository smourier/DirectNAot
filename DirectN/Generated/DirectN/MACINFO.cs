#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MACINFO
{
    public BOOL fUsed;
    public InlineArrayByte_36 abMacState;
}
