namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_CAS_REQUESTTUNERDATA
{
    public byte ucRequestPriority;
    public byte ucRequestReason;
    public byte ucRequestConsequences;
    public uint ulEstimatedTime;
}
