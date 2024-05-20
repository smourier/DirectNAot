#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTEXTSELECTIONINFO
{
    public uint ulStartActiveOffset;
    public uint cchActiveChars;
    public uint ulStartSelection;
    public uint cchSelection;
}
