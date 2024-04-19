namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_WMDRMTUNER_SETPIDPROTECTION
{
    public KSM_NODE NodeMethod;
    public uint ulPID;
    public Guid uuidKeyID;
}
