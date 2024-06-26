﻿#nullable enable
namespace DirectN;

public enum SPVALUETYPE
{
    SPDF_PROPERTY = 1,
    SPDF_REPLACEMENT = 2,
    SPDF_RULE = 4,
    SPDF_DISPLAYTEXT = 8,
    SPDF_LEXICALFORM = 16,
    SPDF_PRONUNCIATION = 32,
    SPDF_AUDIO = 64,
    SPDF_ALTERNATES = 128,
    SPDF_ALL = 255,
}
