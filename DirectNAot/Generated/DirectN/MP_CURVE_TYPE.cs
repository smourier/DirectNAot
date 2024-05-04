#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/ne-medparam-mp_curve_type
public enum MP_CURVE_TYPE
{
    MP_CURVE_JUMP = 1,
    MP_CURVE_LINEAR = 2,
    MP_CURVE_SQUARE = 4,
    MP_CURVE_INVSQUARE = 8,
    MP_CURVE_SINE = 16,
}
