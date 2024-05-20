#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-dvd_textcharset
public enum DVD_TextCharSet
{
    DVD_CharSet_Unicode = 0,
    DVD_CharSet_ISO646 = 1,
    DVD_CharSet_JIS_Roman_Kanji = 2,
    DVD_CharSet_ISO8859_1 = 3,
    DVD_CharSet_ShiftJIS_Kanji_Roman_Katakana = 4,
}
