#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfnominalrange
public enum MFNominalRange
{
    MFNominalRange_Unknown = 0,
    MFNominalRange_Normal = 1,
    MFNominalRange_Wide = 2,
    MFNominalRange_0_255 = 1,
    MFNominalRange_16_235 = 2,
    MFNominalRange_48_208 = 3,
    MFNominalRange_64_127 = 4,
    MFNominalRange_Last = 5,
    MFNominalRange_ForceDWORD = int.MaxValue,
}
