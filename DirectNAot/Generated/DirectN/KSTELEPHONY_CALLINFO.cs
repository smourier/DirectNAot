namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTELEPHONY_CALLINFO
{
    public TELEPHONY_CALLTYPE CallType;
    public TELEPHONY_CALLSTATE CallState;
}
