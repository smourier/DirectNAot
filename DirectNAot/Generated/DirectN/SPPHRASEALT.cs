#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEALT
{
    public nint pPhrase;
    public uint ulStartElementInParent;
    public uint cElementsInParent;
    public uint cElementsInAlternate;
    public nint pvAltExtra;
    public uint cbAltExtra;
}
