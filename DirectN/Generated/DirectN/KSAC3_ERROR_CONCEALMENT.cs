#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAC3_ERROR_CONCEALMENT
{
    public BOOL fRepeatPreviousBlock;
    public BOOL fErrorInCurrentBlock;
}
