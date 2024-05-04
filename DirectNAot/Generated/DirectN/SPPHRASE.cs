#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASE
{
    public SPPHRASE_50 Base;
    public PWSTR pSML;
    public nint pSemanticErrorInfo;
}
