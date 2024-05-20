#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct INSTHEADER
{
    public uint cRegions;
    public MIDILOCALE Locale;
}
