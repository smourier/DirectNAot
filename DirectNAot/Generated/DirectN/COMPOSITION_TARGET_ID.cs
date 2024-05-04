#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ns-dcomptypes-composition_target_id
[StructLayout(LayoutKind.Sequential)]
public partial struct COMPOSITION_TARGET_ID
{
    public LUID displayAdapterLuid;
    public LUID renderAdapterLuid;
    public uint vidPnSourceId;
    public uint vidPnTargetId;
    public uint uniqueId;
}
