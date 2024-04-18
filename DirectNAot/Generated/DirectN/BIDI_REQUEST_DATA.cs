namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BIDI_REQUEST_DATA
{
    public uint dwReqNumber;
    public PWSTR pSchema;
    public BIDI_DATA data;
}
