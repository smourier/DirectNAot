namespace DirectN;

public enum ImageFlags
{
    ImageFlagsNone = 0,
    ImageFlagsScalable = 1,
    ImageFlagsHasAlpha = 2,
    ImageFlagsHasTranslucent = 4,
    ImageFlagsPartiallyScalable = 8,
    ImageFlagsColorSpaceRGB = 16,
    ImageFlagsColorSpaceCMYK = 32,
    ImageFlagsColorSpaceGRAY = 64,
    ImageFlagsColorSpaceYCBCR = 128,
    ImageFlagsColorSpaceYCCK = 256,
    ImageFlagsHasRealDPI = 4096,
    ImageFlagsHasRealPixelSize = 8192,
    ImageFlagsReadOnly = 65536,
    ImageFlagsCaching = 131072,
}
