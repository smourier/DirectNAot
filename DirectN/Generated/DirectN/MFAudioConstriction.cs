#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfaudioconstriction
public enum MFAudioConstriction
{
    MFaudioConstrictionOff = 0,
    MFaudioConstriction48_16 = 1,
    MFaudioConstriction44_16 = 2,
    MFaudioConstriction14_14 = 3,
    MFaudioConstrictionMute = 4,
}
