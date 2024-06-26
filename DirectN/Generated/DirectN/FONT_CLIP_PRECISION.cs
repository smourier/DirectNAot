﻿#nullable enable
namespace DirectN;

[Flags]
public enum FONT_CLIP_PRECISION : byte
{
    CLIP_DEFAULT_PRECIS = 0,
    CLIP_CHARACTER_PRECIS = 1,
    CLIP_STROKE_PRECIS = 2,
    CLIP_MASK = 15,
    CLIP_LH_ANGLES = 16,
    CLIP_TT_ALWAYS = 32,
    CLIP_DFA_DISABLE = 64,
    CLIP_EMBEDDED = 128,
    CLIP_DFA_OVERRIDE = 64,
}
