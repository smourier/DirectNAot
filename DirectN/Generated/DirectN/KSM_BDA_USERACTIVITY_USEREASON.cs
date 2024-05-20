#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_USERACTIVITY_USEREASON
{
    public KSIDENTIFIER Method;
    public uint ulUseReason;
}
