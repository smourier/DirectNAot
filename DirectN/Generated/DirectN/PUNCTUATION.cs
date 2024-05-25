#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-punctuation
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct PUNCTUATION
{
    public uint iSize;
    public PSTR szPunctuation;
}
