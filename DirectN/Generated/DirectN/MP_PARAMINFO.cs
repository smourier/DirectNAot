﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/ns-medparam-mp_paraminfo
public partial struct MP_PARAMINFO
{
    public MP_TYPE mpType;
    public uint mopCaps;
    public float mpdMinValue;
    public float mpdMaxValue;
    public float mpdNeutralValue;
    public InlineArraySystemChar_32 szUnitText;
    public InlineArraySystemChar_32 szLabel;
}
