#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-glyphmetricsfloat
public partial struct GLYPHMETRICSFLOAT
{
    public float gmfBlackBoxX;
    public float gmfBlackBoxY;
    public POINTFLOAT gmfptGlyphOrigin;
    public float gmfCellIncX;
    public float gmfCellIncY;
}
