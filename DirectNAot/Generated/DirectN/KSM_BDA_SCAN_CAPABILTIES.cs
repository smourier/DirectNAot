namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_SCAN_CAPABILTIES
{
    public KSIDENTIFIER Method;
    public Guid uuidBroadcastStandard;
}
