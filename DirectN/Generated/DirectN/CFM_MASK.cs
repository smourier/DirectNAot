﻿#nullable enable
namespace DirectN;

[Flags]
public enum CFM_MASK : uint
{
    CFM_SUBSCRIPT = 196608,
    CFM_SUPERSCRIPT = 196608,
    CFM_EFFECTS = 1073741887,
    CFM_ALL = 4160749631,
    CFM_BOLD = 1,
    CFM_CHARSET = 134217728,
    CFM_COLOR = 1073741824,
    CFM_FACE = 536870912,
    CFM_ITALIC = 2,
    CFM_OFFSET = 268435456,
    CFM_PROTECTED = 16,
    CFM_SIZE = 2147483648,
    CFM_STRIKEOUT = 8,
    CFM_UNDERLINE = 4,
    CFM_LINK = 32,
    CFM_SMALLCAPS = 64,
    CFM_ALLCAPS = 128,
    CFM_HIDDEN = 256,
    CFM_OUTLINE = 512,
    CFM_SHADOW = 1024,
    CFM_EMBOSS = 2048,
    CFM_IMPRINT = 4096,
    CFM_DISABLED = 8192,
    CFM_REVISED = 16384,
    CFM_REVAUTHOR = 32768,
    CFM_ANIMATION = 262144,
    CFM_STYLE = 524288,
    CFM_KERNING = 1048576,
    CFM_SPACING = 2097152,
    CFM_WEIGHT = 4194304,
    CFM_UNDERLINETYPE = 8388608,
    CFM_COOKIE = 16777216,
    CFM_LCID = 33554432,
    CFM_BACKCOLOR = 67108864,
    CFM_EFFECTS2 = 1141080063,
    CFM_ALL2 = uint.MaxValue,
    CFM_FONTBOUND = 1048576,
    CFM_LINKPROTECTED = 8388608,
    CFM_EXTENDED = 33554432,
    CFM_MATHNOBUILDUP = 134217728,
    CFM_MATH = 268435456,
    CFM_MATHORDINARY = 536870912,
    CFM_ALLEFFECTS = 2115207167,
}
