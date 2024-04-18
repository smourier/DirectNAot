namespace DirectN;

public enum GET_GLYPH_OUTLINE_FORMAT : uint
{
    GGO_BEZIER = 3,
    GGO_BITMAP = 1,
    GGO_GLYPH_INDEX = 128,
    GGO_GRAY2_BITMAP = 4,
    GGO_GRAY4_BITMAP = 5,
    GGO_GRAY8_BITMAP = 6,
    GGO_METRICS = 0,
    GGO_NATIVE = 2,
    GGO_UNHINTED = 256,
}
