#nullable enable
namespace DirectN;

public enum EncoderValue
{
    EncoderValueColorTypeCMYK = 0,
    EncoderValueColorTypeYCCK = 1,
    EncoderValueCompressionLZW = 2,
    EncoderValueCompressionCCITT3 = 3,
    EncoderValueCompressionCCITT4 = 4,
    EncoderValueCompressionRle = 5,
    EncoderValueCompressionNone = 6,
    EncoderValueScanMethodInterlaced = 7,
    EncoderValueScanMethodNonInterlaced = 8,
    EncoderValueVersionGif87 = 9,
    EncoderValueVersionGif89 = 10,
    EncoderValueRenderProgressive = 11,
    EncoderValueRenderNonProgressive = 12,
    EncoderValueTransformRotate90 = 13,
    EncoderValueTransformRotate180 = 14,
    EncoderValueTransformRotate270 = 15,
    EncoderValueTransformFlipHorizontal = 16,
    EncoderValueTransformFlipVertical = 17,
    EncoderValueMultiFrame = 18,
    EncoderValueLastFrame = 19,
    EncoderValueFlush = 20,
    EncoderValueFrameDimensionTime = 21,
    EncoderValueFrameDimensionResolution = 22,
    EncoderValueFrameDimensionPage = 23,
    EncoderValueColorTypeGray = 24,
    EncoderValueColorTypeRGB = 25,
}
