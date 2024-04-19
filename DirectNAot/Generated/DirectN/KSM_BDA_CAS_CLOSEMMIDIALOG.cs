namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_CAS_CLOSEMMIDIALOG
{
    public KSM_NODE NodeMethod;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR12 cLanguage;
    public uint ulDialogNumber;
    public uint ulReason;
}
