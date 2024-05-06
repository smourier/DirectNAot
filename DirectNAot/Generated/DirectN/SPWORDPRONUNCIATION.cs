#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDPRONUNCIATION
{
    public nint pNextWordPronunciation;
    public SPLEXICONTYPE eLexiconType;
    public ushort LangID;
    public ushort wPronunciationFlags;
    public SPPARTOFSPEECH ePartOfSpeech;
    public InlineArrayUInt16_1 szPronunciation; // variable-length array placeholder
}
