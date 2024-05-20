#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EXBMINFOHEADER
{
    public BITMAPINFOHEADER bmi;
    public uint biExtDataOffset;
}
