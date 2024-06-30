#nullable enable
namespace DirectN;

public partial struct BDA_DRM_DRMSTATUS
{
    public int lResult;
    public Guid DRMuuid;
    public uint ulDrmUuidListStringSize;
    public InlineArrayGuid_1 argbDrmUuidListString; // variable-length array placeholder
}
