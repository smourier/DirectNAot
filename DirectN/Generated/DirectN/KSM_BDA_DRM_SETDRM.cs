#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_DRM_SETDRM
{
    public KSM_NODE NodeMethod;
    public Guid NewDRMuuid;
}
