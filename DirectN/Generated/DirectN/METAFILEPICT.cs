#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-metafilepict
public partial struct METAFILEPICT
{
    public int mm;
    public int xExt;
    public int yExt;
    public HMETAFILE hMF;
}
