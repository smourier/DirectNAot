#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/ns-medparam-mp_envelope_segment
[StructLayout(LayoutKind.Sequential)]
public partial struct MP_ENVELOPE_SEGMENT
{
    public long rtStart;
    public long rtEnd;
    public float valStart;
    public float valEnd;
    public MP_CURVE_TYPE iCurve;
    public uint flags;
}
