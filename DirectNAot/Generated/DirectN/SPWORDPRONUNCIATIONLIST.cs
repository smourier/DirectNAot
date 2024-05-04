#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDPRONUNCIATIONLIST
{
    public uint ulSize;
    public nint pvBuffer;
    public nint pFirstWordPronunciation;
}
