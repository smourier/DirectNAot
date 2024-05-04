#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_WMDRMTUNER_GETPIDPROTECTION
{
    public KSM_NODE NodeMethod;
    public uint ulPID;
}
