#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/ns-medparam-mp_paraminfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MP_PARAMINFO
{
    public MP_TYPE mpType;
    public uint mopCaps;
    public float mpdMinValue;
    public float mpdMaxValue;
    public float mpdNeutralValue;
    public InlineArraySystemChar32 szUnitText;
    public InlineArraySystemChar32 szLabel;
}
