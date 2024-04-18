namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UNI_CODEPAGEINFO
{
    public uint dwCodePage;
    public INVOC SelectSymbolSet;
    public INVOC UnSelectSymbolSet;
}
