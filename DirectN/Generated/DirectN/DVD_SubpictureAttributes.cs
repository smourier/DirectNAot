#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_subpictureattributes
public partial struct DVD_SubpictureAttributes
{
    public DVD_SUBPICTURE_TYPE Type;
    public DVD_SUBPICTURE_CODING CodingMode;
    public uint Language;
    public DVD_SUBPICTURE_LANG_EXT LanguageExtension;
}
