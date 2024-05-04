#nullable enable
namespace DirectN;

public enum DitherType
{
    DitherTypeNone = 0,
    DitherTypeSolid = 1,
    DitherTypeOrdered4x4 = 2,
    DitherTypeOrdered8x8 = 3,
    DitherTypeOrdered16x16 = 4,
    DitherTypeSpiral4x4 = 5,
    DitherTypeSpiral8x8 = 6,
    DitherTypeDualSpiral4x4 = 7,
    DitherTypeDualSpiral8x8 = 8,
    DitherTypeErrorDiffusion = 9,
    DitherTypeMax = 10,
}
