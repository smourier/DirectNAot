namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_subpictureattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_SubpictureAttributes
{
    public DVD_SUBPICTURE_TYPE Type;
    public DVD_SUBPICTURE_CODING CodingMode;
    public uint Language;
    public DVD_SUBPICTURE_LANG_EXT LanguageExtension;
}
