namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEALTREQUEST
{
    public uint ulStartElement;
    public uint cElements;
    public uint ulRequestAltCount;
    public nint pvResultExtra;
    public uint cbResultExtra;
    public nint pPhrase;
    public nint pRecoContext;
}
