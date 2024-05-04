#nullable enable
namespace DirectN;

[Flags]
public enum ADVANCED_FEATURE_FLAGS : ushort
{
    FADF_AUTO = 1,
    FADF_STATIC = 2,
    FADF_EMBEDDED = 4,
    FADF_FIXEDSIZE = 16,
    FADF_RECORD = 32,
    FADF_HAVEIID = 64,
    FADF_HAVEVARTYPE = 128,
    FADF_BSTR = 256,
    FADF_UNKNOWN = 512,
    FADF_DISPATCH = 1024,
    FADF_VARIANT = 2048,
    FADF_RESERVED = 61448,
}
