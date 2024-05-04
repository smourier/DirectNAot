#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_CAS_OPENBROADCASTMMI
{
    public KSM_NODE NodeMethod;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR12 cLanguage;
    public uint ulEventId;
}
