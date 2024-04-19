namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideolighting
public enum MFVideoLighting
{
    MFVideoLighting_Unknown = 0,
    MFVideoLighting_bright = 1,
    MFVideoLighting_office = 2,
    MFVideoLighting_dim = 3,
    MFVideoLighting_dark = 4,
    MFVideoLighting_Last = 5,
    MFVideoLighting_ForceDWORD = int.MaxValue,
}
