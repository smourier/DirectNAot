#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXBMINFOHEADER
{
    public BITMAPINFOHEADER bmi;
    public uint biExtDataOffset;
}
