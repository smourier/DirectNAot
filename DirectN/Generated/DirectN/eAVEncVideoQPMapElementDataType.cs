#nullable enable
namespace DirectN;

public enum eAVEncVideoQPMapElementDataType
{
    CODEC_API_QP_MAP_INT8 = 0,
    CODEC_API_QP_MAP_INT16 = 1,
    CODEC_API_QP_MAP_INT32 = 2,
    CODEC_API_QP_MAP_UINT8 = int.MinValue,
    CODEC_API_QP_MAP_UINT16 = -2147483647,
    CODEC_API_QP_MAP_UINT32 = -2147483646,
}
