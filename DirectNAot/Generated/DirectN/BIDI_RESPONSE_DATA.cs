namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BIDI_RESPONSE_DATA
{
    public uint dwResult;
    public uint dwReqNumber;
    public PWSTR pSchema;
    public BIDI_DATA data;
}
