#nullable enable
namespace DirectN;

public enum ImageCodecFlags
{
    ImageCodecFlagsEncoder = 1,
    ImageCodecFlagsDecoder = 2,
    ImageCodecFlagsSupportBitmap = 4,
    ImageCodecFlagsSupportVector = 8,
    ImageCodecFlagsSeekableEncode = 16,
    ImageCodecFlagsBlockingDecode = 32,
    ImageCodecFlagsBuiltin = 65536,
    ImageCodecFlagsSystem = 131072,
    ImageCodecFlagsUser = 262144,
}
