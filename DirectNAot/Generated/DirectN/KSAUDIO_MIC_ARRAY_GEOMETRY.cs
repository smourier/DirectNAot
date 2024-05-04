#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MIC_ARRAY_GEOMETRY
{
    public ushort usVersion;
    public ushort usMicArrayType;
    public short wVerticalAngleBegin;
    public short wVerticalAngleEnd;
    public short wHorizontalAngleBegin;
    public short wHorizontalAngleEnd;
    public ushort usFrequencyBandLo;
    public ushort usFrequencyBandHi;
    public ushort usNumberOfMicrophones;
    public InlineArrayKSAUDIO_MICROPHONE_COORDINATES1 KsMicCoord; // variable-length array placeholder
}
