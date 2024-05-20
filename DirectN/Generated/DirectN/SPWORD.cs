#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORD
{
    public nint pNextWord;
    public ushort LangID;
    public ushort wReserved;
    public SPWORDTYPE eWordType;
    public PWSTR pszWord;
    public nint pFirstWordPronunciation;
}
