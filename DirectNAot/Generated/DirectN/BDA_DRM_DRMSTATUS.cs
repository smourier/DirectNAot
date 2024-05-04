#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_DRM_DRMSTATUS
{
    public int lResult;
    public Guid DRMuuid;
    public uint ulDrmUuidListStringSize;
    public InlineArrayGuid1 argbDrmUuidListString; // variable-length array placeholder
}
