﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_font_feature_tag
public enum DWRITE_FONT_FEATURE_TAG : uint
{
    DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS = 1668441697,
    DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS = 1668297315,
    DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS = 1668493923,
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES = 1953259875,
    DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS = 1702060387,
    DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION = 1886217059,
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES = 1734962275,
    DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING = 1886613603,
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH = 1752658787,
    DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING = 1936880995,
    DWRITE_FONT_FEATURE_TAG_DEFAULT = 1953261156,
    DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES = 1734962276,
    DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS = 1953527909,
    DWRITE_FONT_FEATURE_TAG_FRACTIONS = 1667330662,
    DWRITE_FONT_FEATURE_TAG_FULL_WIDTH = 1684633446,
    DWRITE_FONT_FEATURE_TAG_HALF_FORMS = 1718378856,
    DWRITE_FONT_FEATURE_TAG_HALANT_FORMS = 1852596584,
    DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH = 1953259880,
    DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS = 1953720680,
    DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES = 1634626408,
    DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES = 1734962280,
    DWRITE_FONT_FEATURE_TAG_HALF_WIDTH = 1684633448,
    DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS = 1869246312,
    DWRITE_FONT_FEATURE_TAG_JIS04_FORMS = 875589738,
    DWRITE_FONT_FEATURE_TAG_JIS78_FORMS = 943157354,
    DWRITE_FONT_FEATURE_TAG_JIS83_FORMS = 859336810,
    DWRITE_FONT_FEATURE_TAG_JIS90_FORMS = 809070698,
    DWRITE_FONT_FEATURE_TAG_KERNING = 1852990827,
    DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES = 1634167148,
    DWRITE_FONT_FEATURE_TAG_LINING_FIGURES = 1836412524,
    DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS = 1818455916,
    DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING = 1802658157,
    DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK = 1802659693,
    DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING = 1802333037,
    DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS = 1953259886,
    DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS = 1801677934,
    DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES = 1836412527,
    DWRITE_FONT_FEATURE_TAG_ORDINALS = 1852076655,
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH = 1953259888,
    DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS = 1885430640,
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES = 1836412528,
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS = 1684633456,
    DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS = 1684633457,
    DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES = 1734962290,
    DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS = 2036495730,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES = 1953259891,
    DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS = 1718511987,
    DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS = 1885564275,
    DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS = 1819307379,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1 = 825258867,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2 = 842036083,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3 = 858813299,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4 = 875590515,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5 = 892367731,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6 = 909144947,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7 = 925922163,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8 = 942699379,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9 = 959476595,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10 = 808547187,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11 = 825324403,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12 = 842101619,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13 = 858878835,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14 = 875656051,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15 = 892433267,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16 = 909210483,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17 = 925987699,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18 = 942764915,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19 = 959542131,
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20 = 808612723,
    DWRITE_FONT_FEATURE_TAG_SUBSCRIPT = 1935832435,
    DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT = 1936749939,
    DWRITE_FONT_FEATURE_TAG_SWASH = 1752397683,
    DWRITE_FONT_FEATURE_TAG_TITLING = 1819568500,
    DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS = 1835101812,
    DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES = 1836412532,
    DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS = 1684107892,
    DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS = 1684633460,
    DWRITE_FONT_FEATURE_TAG_UNICASE = 1667853941,
    DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING = 1953654134,
    DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION = 846492278,
    DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO = 1869768058,
}
